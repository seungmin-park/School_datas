package com.inhatc.cs.DataSource;

import com.inhatc.cs.AppConfig;
import org.junit.Test;
import org.junit.runner.RunWith;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.test.context.ContextConfiguration;
import org.springframework.test.context.junit4.SpringJUnit4ClassRunner;
import org.springframework.test.context.web.WebAppConfiguration;

import javax.sql.DataSource;
import java.sql.Connection;

@WebAppConfiguration
@RunWith(SpringJUnit4ClassRunner.class)
@ContextConfiguration(classes = AppConfig.class)
public class DataSourceTest {

    @Autowired
    DataSource dataSource;

    @Test
    public void testConnection() throws Exception {
        try(Connection con = dataSource.getConnection()){
            System.out.println(con);
        }catch (Exception e) {
            e.printStackTrace();
        }
    }
}
