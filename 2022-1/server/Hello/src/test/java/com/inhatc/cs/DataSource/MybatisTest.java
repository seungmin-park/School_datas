package com.inhatc.cs.DataSource;

import com.inhatc.cs.AppConfig;
import org.apache.ibatis.session.SqlSession;
import org.apache.ibatis.session.SqlSessionFactory;
import org.junit.Test;
import org.junit.runner.RunWith;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.test.context.ContextConfiguration;
import org.springframework.test.context.junit4.SpringJUnit4ClassRunner;
import org.springframework.test.context.web.WebAppConfiguration;

@WebAppConfiguration
@RunWith(SpringJUnit4ClassRunner.class)
@ContextConfiguration(classes = AppConfig.class)
public class MybatisTest {
    @Autowired
    SqlSessionFactory sqlSessionFactory;

    @Test
    public void testSession() throws Exception{

        try {
            SqlSession session = sqlSessionFactory.openSession();
            System.out.println(session);
        }catch (Exception e){
            e.printStackTrace();
        }
    }
}
