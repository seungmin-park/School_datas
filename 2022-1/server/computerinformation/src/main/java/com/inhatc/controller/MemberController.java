package com.inhatc.controller;

import com.inhatc.domain.Member;
import com.inhatc.repository.MemberRepository;
import lombok.RequiredArgsConstructor;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;

@Controller
@RequiredArgsConstructor
public class MemberController {

    private final MemberRepository memberRepository;

    @GetMapping("/member")
    public String members(Model model) {
        Member member = new Member();
        member.setUsername("memberA");
        Member savedMember = memberRepository.save(member);

        model.addAttribute("member", savedMember);

        return "index";
    }
}
