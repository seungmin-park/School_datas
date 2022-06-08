package com.inhatc.persistence;

import java.util.List;

import javax.inject.Inject;

import org.apache.ibatis.session.SqlSession;
import org.springframework.stereotype.Repository;
import com.inhatc.domain.BoardVO;
import com.inhatc.domain.Criteria;
import com.inhatc.domain.SearchCriteria;

/**
 * @Repository을 사용하여 자동으로 Spring Bean 등록
 * @Inject를 통해 자동 주입 -> 개방 폐쇄 원칙
 */
@Repository
public class BoardDAOImpl implements BoardDAO {

  @Inject
  private SqlSession session;

//  mapper.xml namespace와 일치
  private static String namespace = "com.inhatc.mapper.BoardMapper";

  /**
   * vo 객체를 db에 저장 게시물 저장에 사용
   * @param vo
   * @throws Exception
   */
  @Override
  public void create(BoardVO vo) throws Exception {
    session.insert(namespace + ".create", vo);
  }
  
  /**
   * 파라미터로 넘겨준 bno에 해당하는 게시물 하나 select 자세히 보기 사용
   * @param bno
   * @return
   * @throws Exception
   */
  @Override
  public BoardVO read(Integer bno) throws Exception {
    return session.selectOne(namespace + ".read", bno);
  }

  /**
   * 파라미터로 넘겨준 bno에 해당하는 게시물 하나 update 게시물 수정에 사용
   * @param vo
   * @throws Exception
   */
  @Override
  public void update(BoardVO vo) throws Exception {
    session.update(namespace + ".update", vo);
  }

  /**
   * 파라미터로 넘겨준 bno에 해당하는 게시물 하나 delete 게시물 삭제에 사용
   * @param bno
   * @throws Exception
   */
  @Override
  public void delete(Integer bno) throws Exception {
    session.delete(namespace + ".delete", bno);
  }


  /**
   * tbl_board 존재하는 모든 게시물 조회
   * 너무 많은 양의 데이터를 한번에 조회하는 문제점 발생
   * @return
   * @throws Exception
   */
  @Override
  public List<BoardVO> listAll() throws Exception {
    return session.selectList(namespace + ".listAll");
  }
  
  /**
   * listAll의 문제점 개선 -> 페이징 처리
   * 특정 인덱스부터 일정 개수의 데이터만 조회
   * 파라미터로 넘어오는 page가 음수면 에러가 발생할 수 있음
   * 사용자의 페이지 시작은 1번부터 이지만 sql문에서는 0부터 시작
   * @param page
   * @return
   * @throws Exception
   */
  @Override
  public List<BoardVO> listPage(int page) throws Exception {

    if (page <= 0) {
      page = 1;
    }

//    * 10을 안해주면 페이지가 넘어감에 따라 데이터가 1개씩 줄어든다.
    page = (page - 1) * 10;

    return session.selectList(namespace + ".listPage", page);
  }

  /**
   * listPage는 무조건 데이터를 10개 씩 조회
   * Criteria의 perPageNum을 통해 페이지마다 조회하고 싶은 개수를 지정
   * 기본 생성자로 사용자가 파라미터를 넘기지 않아도 자동으로 1페이지부터 시작, 페이지당 개수 10개 설정으로 오류 발생회피
   * @param cri
   * @return
   * @throws Exception
   */
  @Override
  public List<BoardVO> listCriteria(Criteria cri) throws Exception {

    return session.selectList(namespace + ".listCriteria", cri);
  }

  /**
   * 전체 게시물의 개수 조회
   * @param cri
   * @return
   * @throws Exception
   */
  @Override
  public int countPaging(Criteria cri) throws Exception {

    return session.selectOne(namespace + ".countPaging", cri);
  }

  @Override    
  public List<BoardVO> listSearch(SearchCriteria cri) throws Exception {

    return session.selectList(namespace + ".listSearch", cri);
  }

  @Override
  public int listSearchCount(SearchCriteria cri) throws Exception {

    return session.selectOne(namespace + ".listSearchCount", cri);
  }


}
