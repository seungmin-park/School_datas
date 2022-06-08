package com.inhatc.cs;

import javax.inject.Inject;

import com.inhatc.persistence.BoardDAO;
import org.junit.Test;
import org.junit.runner.RunWith;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.test.context.ContextConfiguration;
import org.springframework.test.context.junit4.SpringJUnit4ClassRunner;

import com.inhatc.domain.BoardVO;

@RunWith(SpringJUnit4ClassRunner.class)
@ContextConfiguration(locations = { "file:src/main/webapp/WEB-INF/spring/**/*.xml" })
public class BoardDAOTest {

  @Inject
  private BoardDAO dao;

  private static Logger logger = LoggerFactory.getLogger(BoardDAOTest.class);

  @Test
  public void testCreate() throws Exception {

    BoardVO board = new BoardVO();
    board.setTitle("새글입력 ");
    board.setContent("이글은 새글입니다. ");
    board.setWriter("user00");
    dao.create(board);
  }

  @Test
  public void testRead() throws Exception {

    logger.info(dao.read(1).toString());
  }

  @Test
  public void testUpdate() throws Exception {

    BoardVO board = new BoardVO();
    board.setBno(2);
    board.setTitle("수정된 글.");
    board.setContent("수정된 글 테스트 용");
    dao.update(board);
  }

  @Test
  public void testDelete() throws Exception {

    dao.delete(3);
  }

  
}
