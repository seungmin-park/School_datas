package com.inhatc.cs.repository;

import com.inhatc.cs.AppConfig;
import com.inhatc.cs.domain.Member;
import lombok.extern.slf4j.Slf4j;
import org.assertj.core.api.Assertions;
import org.junit.Test;
import org.junit.runner.RunWith;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.test.context.ContextConfiguration;
import org.springframework.test.context.junit4.SpringJUnit4ClassRunner;
import org.springframework.test.context.web.WebAppConfiguration;

@Slf4j
@RunWith(SpringJUnit4ClassRunner.class)
@WebAppConfiguration
@ContextConfiguration(classes = AppConfig.class)
public class MemberRepositoryTest {

    @Autowired
    private MemberRepository memberRepository;

    @Test
    public void saveMember() throws Exception {
        //given
        Member member = new Member("memberA", 10);

        Member savedMember = memberRepository.save(member);
        //when
        Member findMember = memberRepository.findById(member.getId());
        //then
        Assertions.assertThat(savedMember).isEqualTo(findMember);
    }
}