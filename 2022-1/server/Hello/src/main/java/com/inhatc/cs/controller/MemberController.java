package com.inhatc.cs.controller;

import com.inhatc.cs.domain.Member;
import com.inhatc.cs.repository.MemberRepository;
import lombok.RequiredArgsConstructor;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;

@Controller
@RequiredArgsConstructor
public class MemberController {

    private final MemberRepository memberRepository;

    @GetMapping("/member")
    public String member(Model model) {
        Member member = new Member("서찬원", 24);
        Member savedMember = memberRepository.save(member);

        model.addAttribute("member", savedMember);

        return "member";
    }
}
