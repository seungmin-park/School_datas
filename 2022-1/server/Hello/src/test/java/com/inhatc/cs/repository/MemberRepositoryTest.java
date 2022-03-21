package com.inhatc.cs.repository;

import com.inhatc.cs.AppConfig;
import com.inhatc.cs.dto.MemberDto;
import lombok.extern.slf4j.Slf4j;
import org.assertj.core.api.Assertions;
import org.junit.Test;
import org.junit.runner.RunWith;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.test.context.ContextConfiguration;
import org.springframework.test.context.junit4.SpringJUnit4ClassRunner;
import org.springframework.test.context.web.WebAppConfiguration;

@Slf4j
@WebAppConfiguration
@RunWith(SpringJUnit4ClassRunner.class)
@ContextConfiguration(classes = AppConfig.class)
public class MemberRepositoryTest {

    @Autowired
    private MemberRepository memberRepository;

    @Test
    public void saveMember() throws Exception {
        //given
//        Member member = new Member("memberA", 10);
        memberRepository.dropDB();
        memberRepository.createDB();

        //when
        MemberDto member = new MemberDto(1L, "memberA", 10);

        memberRepository.insert(member);
        MemberDto findMember = memberRepository.findById(member.getId());
        //then
        Assertions.assertThat(member.getId()).isEqualTo(findMember.getId());
        Assertions.assertThat(member.getAge()).isEqualTo(findMember.getAge());
        Assertions.assertThat(member.getUsername()).isEqualTo(findMember.getUsername());
        Assertions.assertThat(member).isEqualTo(findMember);
    }
}