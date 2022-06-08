package com.inhatc.service;

import java.util.List;

import javax.inject.Inject;

import org.springframework.stereotype.Service;
import com.inhatc.domain.BoardVO;
import com.inhatc.domain.Criteria;
import com.inhatc.domain.SearchCriteria;
import com.inhatc.persistence.BoardDAO;

/**
 * @Repository을 사용하여 자동으로 Spring Bean 등록
 * @Inject를 통해 자동 주입 -> 개방 폐쇄 원칙
 */
@Service
public class BoardServiceImpl implements BoardService {

  @Inject
  private BoardDAO dao;

  /**
   * 사용자가 입력한 데이터를 boardDAO를 사용하여 저장
   * @param board
   * @throws Exception
   */
  @Override
  public void regist(BoardVO board) throws Exception {
    dao.create(board);
  }

  /**
   * bno에 해당되는 게시물 하나 조회
   * 특정 게시물 상세 페이지
   * @param bno
   * @return
   * @throws Exception
   */
  @Override
  public BoardVO read(Integer bno) throws Exception {
    return dao.read(bno);
  }

  /**
   * board에 존재하는 bno에 해당되는 게시물 수정
   * 특정 게시물 상세 페이지에서 수정을 통해 제목과 내용 update
   * @param board
   * @throws Exception
   */
  @Override
  public void modify(BoardVO board) throws Exception {
    dao.update(board);
  }

  @Override
  public void modifyPage(BoardVO board) throws Exception {
    dao.update(board);
  }
  
  
  @Override
  public void remove(Integer bno) throws Exception {
    dao.delete(bno);
  }

  @Override
  public List<BoardVO> listAll() throws Exception {
    return dao.listAll();
  }

  @Override
  public List<BoardVO> listCriteria(Criteria cri) throws Exception {

    return dao.listCriteria(cri);
  }

  @Override
  public int listCountCriteria(Criteria cri) throws Exception {

    return dao.countPaging(cri);
  }

  @Override
  public List<BoardVO> listSearchCriteria(SearchCriteria cri) throws Exception {

    return dao.listSearch(cri);
  }

  @Override
  public int listSearchCount(SearchCriteria cri) throws Exception {

    return dao.listSearchCount(cri);
  }

}
