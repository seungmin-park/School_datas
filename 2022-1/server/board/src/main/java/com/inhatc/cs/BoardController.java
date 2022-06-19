package com.inhatc.cs;

import javax.inject.Inject;

import com.inhatc.domain.Criteria;
import com.inhatc.domain.PageMaker;
import com.inhatc.service.BoardService;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.servlet.mvc.support.RedirectAttributes;

import com.inhatc.domain.BoardVO;


/**
 * return 타입이 void인 메소드는 Mapping의 value로 view를 찾아 렌더링
 */
@Controller
@RequestMapping("/board/*")
public class BoardController {
  
  @Inject
  private BoardService service;

  /**
   * register.jsp 렌더링
   * @param board
   * @param model
   * @throws Exception
   */
  @RequestMapping(value = "/register", method = RequestMethod.GET)
  public void registerGET(BoardVO board, Model model) throws Exception {

    System.out.println("register get ...........");
//    return "register";
  }

  /**
   * register1.jsp 렌더링
   * @param board
   * @param model
   * @throws Exception
   */
  @RequestMapping(value = "/register1", method = RequestMethod.GET)
  public void register1GET(BoardVO board, Model model) throws Exception {

    System.out.println("register get ...........");
    //return "register";
  }

  /**
   * register.jsp 에서 사용자가 입력한 input name 속성 값과 일치하는  board 내에 setter 호출하여 데이터 초기화
   * @RequestParam도 생략이 가능 한데 , 스프링은 몇가지 단순 타입(String, int)등은 @RequestParam
   * 그외의 복잡한 오브젝트는 모두 @ModelAttribute가 생략 됐다고 간주
   * @param board
   * @param model
   * @return
   * @throws Exception
   */
  @RequestMapping(value = "/register", method = RequestMethod.POST)
  public String registPOST(BoardVO board, Model model) throws Exception {
  
	  System.out.println("regist post ...........");
	  System.out.println(board.toString());
  
   service.regist(board);
  
   model.addAttribute("result", "success");
  
  return "/board/success";
  // return "redirect:/board/listAll";
  }


  /**
   * service를 통해 전체 게시물을 조회하여 listAll.jsp 렌더링
   * @param model
   * @throws Exception
   */
  @RequestMapping(value = "/listAll", method = RequestMethod.GET)
  public void listAll(Model model) throws Exception {

    System.out.println("show all list......................");
    model.addAttribute("list", service.listAll());
  }

  @RequestMapping(value = "/listAll2", method = RequestMethod.GET)
  public void listAll2(Model model) throws Exception {

    System.out.println("show all list......................");
    model.addAttribute("list", service.listAll());
  }

  /**
   * ?bno=value 를 통해 얻은 value에 해당되는 게시물 조회
   * read.jsp 렌더링
   * model.addAttribute arrtibuteName 생략시 객체 타입 앞 글자 소문자로 변경후 arrtibuteName으로 사용 ex) BoardVO -> boardVO
   * @param bno
   * @param model
   * @throws Exception
   */
  @RequestMapping(value = "/read", method = RequestMethod.GET)
  public void read(@RequestParam("bno") int bno, Model model) throws Exception {

    model.addAttribute(service.read(bno));
  }

  /**
   * ?bno=value 를 통해 얻은 value에 해당되는 게시물 조회 페이지에서 삭제 버튼 클릭시 작동
   * retrun 시 redirect 사용 if retrun "/board/listAll"; -> 새로고침시 Post method remove 계속 동작
   * remove가 아닌 create일 경우 새로고침시 똑같은 데이터 계속 생성
   * POST -> REDIRECT -> GET
   * @param bno
   * @param rttr
   * @return
   * @throws Exception
   */
  @RequestMapping(value = "/remove", method = RequestMethod.POST)
  public String remove(@RequestParam("bno") int bno, RedirectAttributes rttr) throws Exception {

    service.remove(bno);

    rttr.addFlashAttribute("msg", "SUCCESS");

    return "redirect:/board/listAll";
  }

  /**
   * ?bno=value 를 통해 얻은 value에 해당되는 게시물 조회
   * modify.jsp 렌더링 -> 게시물을 수정할 수 있는 페이지
   * model.addAttribute arrtibuteName 생략시 객체 타입 앞 글자 소문자로 변경후 arrtibuteName으로 사용 ex) BoardVO -> boardVO
   * @param bno
   * @param model
   * @throws Exception
   */
  @RequestMapping(value = "/modify", method = RequestMethod.GET)
  public void modifyGET(int bno, Model model) throws Exception {
    model.addAttribute(service.read(bno));
  }

  /**
   * ?bno=value 를 통해 얻은 value에 해당되는 게시물 수정 페이지에서 저장 버튼 클릭시 작동
   * retrun 시 redirect 사용 if return "/board/listAll"; -> 새로고침시 Post method update 계속 동작
   * remove가 아닌 create일 경우 새로고침시 똑같은 데이터 계속 생성
   * POST -> REDIRECT -> GET
   * @param board
   * @param rttr
   * @return
   * @throws Exception
   */
  @RequestMapping(value = "/modify", method = RequestMethod.POST)
  public String modifyPOST(BoardVO board, RedirectAttributes rttr) throws Exception {
    service.modify(board);
    rttr.addFlashAttribute("msg", "SUCCESS");
    return "redirect:/board/listAll";
  }

  /**
   * 게시물 목록 페이지는 존재하는 모든 데이터를 조회하여 많은 양을 한 번에 보여주는 문제 발생
   * 일정량의 데이터만 보여주는 페이징 처리
   * 사용자가 paramter를 입력하지 않으면 오류 발생 -> Criteria 기본 생성자를 통해 page=1, perPageNum=10으로 초기화하여 해결
   * @param cri
   * @param model
   * @throws Exception
   */
  @RequestMapping(value = "/listCri", method = RequestMethod.GET)
  public void listAll(Criteria cri, Model model) throws Exception {

	  System.out.println("show list Page with Criteria......................");

    model.addAttribute("list", service.listCriteria(cri));
  }

  /**
   * /listCri에서는 페이지 이동에 불편함 존재 -> 사용자가 주소창에 직접 파라미터를 입력해야함 ex)?page=2&perPageNum=10
   * 사용자의 사용 경험을 높이기 위해 페이지 선택 기능 추가
   * @param cri
   * @param model
   * @throws Exception
   */
  @RequestMapping(value = "/listPage", method = RequestMethod.GET)
  public void listPage(@ModelAttribute("cri") Criteria cri, Model model) throws Exception {

	  System.out.println(cri.toString());

    model.addAttribute("list", service.listCriteria(cri));
    PageMaker pageMaker = new PageMaker();
    pageMaker.setCri(cri);
    // pageMaker.setTotalCount(131);

    pageMaker.setTotalCount(service.listCountCriteria(cri));

    model.addAttribute("pageMaker", pageMaker);
  }

  /**
   * Criteria가 파라미터로 존재하는 이유: 사용자의 사용 경험 향상을 위해
   * 사용자가 특정 게시물을 수정 또는 삭제를 하였을 때 이전 까지 보던 페이지로 다시 쉽게 돌아가기 위해서
   * @param bno
   * @param cri
   * @param model
   * @throws Exception
   */
  @RequestMapping(value = "/readPage", method = RequestMethod.GET)
  public void read(@RequestParam("bno") int bno, @ModelAttribute("cri") Criteria cri, Model model) throws Exception {

    model.addAttribute(service.read(bno));
  }

  @RequestMapping(value = "/removePage", method = RequestMethod.POST)
  public String remove(@RequestParam("bno") int bno, Criteria cri, RedirectAttributes rttr) throws Exception {

    service.remove(bno);

    rttr.addAttribute("page", cri.getPage());
    rttr.addAttribute("perPageNum", cri.getPerPageNum());
    rttr.addFlashAttribute("msg", "SUCCESS");
    
    return "redirect:/board/listPage";
  }

  @RequestMapping(value = "/modifyPage", method = RequestMethod.GET)
  public void modifyPagingGET(@RequestParam("bno") int bno, @ModelAttribute("cri") Criteria cri, Model model)
      throws Exception {

    model.addAttribute(service.read(bno));
  }
  
  @RequestMapping(value = "/modifyPage", method = RequestMethod.POST)
  public String modifyPagePOST(BoardVO board, Criteria cri, RedirectAttributes rttr) throws Exception {

	  System.out.println("mod post............");

    service.modify(board);
    rttr.addAttribute("page", cri.getPage());
    rttr.addAttribute("perPageNum", cri.getPerPageNum());
    rttr.addFlashAttribute("msg", "SUCCESS");

    return "redirect:/board/listPage";
  }

}
