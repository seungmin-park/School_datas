package com.inhatc;

import com.inhatc.cs.AppConfig;
import com.inhatc.cs.domain.MemberVO;
import com.inhatc.cs.repository.MemberDAO;
import org.junit.Test;
import org.junit.runner.RunWith;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.test.context.ContextConfiguration;
import org.springframework.test.context.junit4.SpringJUnit4ClassRunner;
import org.springframework.test.context.web.WebAppConfiguration;

@WebAppConfiguration
@RunWith(SpringJUnit4ClassRunner.class)
@ContextConfiguration(classes = AppConfig.class)
public class MemberDAOTest {

    @Autowired
    MemberDAO memberDAO;

    @Test
    public void TimeTest() throws Exception {
        System.out.println("memberDAO.getTime() = " + memberDAO.getTime());
    }

    @Test
    public void insertTest() throws Exception{
        memberDAO.insertMember(new MemberVO("2","박승민","12345","201844050@itc.ac.kr"));
    }
}
