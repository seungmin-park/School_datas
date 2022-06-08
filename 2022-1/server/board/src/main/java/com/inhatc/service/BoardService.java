package com.inhatc.service;

import java.util.List;

import com.inhatc.domain.BoardVO;
import com.inhatc.domain.Criteria;
import com.inhatc.domain.SearchCriteria;

/**
 * BoardService 인터페이스 정의
 * 의존관계 역전 원칙 적용
 * 구현체를 변경하여도 BoardService를 사용하는 다른 객체에 영향X
 */
public interface BoardService {

  public void regist(BoardVO board) throws Exception;

  public BoardVO read(Integer bno) throws Exception;

  public void modify(BoardVO board) throws Exception;
  
  public void modifyPage(BoardVO board) throws Exception;

  public void remove(Integer bno) throws Exception;

  public List<BoardVO> listAll() throws Exception;


  public List<BoardVO> listCriteria(Criteria cri) throws Exception;

  public int listCountCriteria(Criteria cri) throws Exception;

  public List<BoardVO> listSearchCriteria(SearchCriteria cri) 
      throws Exception;

  public int listSearchCount(SearchCriteria cri) throws Exception;

}
