package com.inhatc;

import com.inhatc.repository.MemberRepository;
import com.inhatc.repository.MemberRepositoryImpl;
import org.junit.Test;
import com.inhatc.domain.Member;
import org.springframework.context.annotation.AnnotationConfigApplicationContext;

public class MemberRepositoryTest {

    AnnotationConfigApplicationContext ac =new AnnotationConfigApplicationContext(AppConfig.class);


    @Test
    public void saveMember() {
        MemberRepository memberRepository = ac.getBean(MemberRepository.class);
        Member member = new Member();
        member.setUsername("member");

        Member savedMember = memberRepository.save(member);

        Member findMember = memberRepository.findById(member.getId());

        System.out.println("result = " + (findMember == savedMember));
    }

}