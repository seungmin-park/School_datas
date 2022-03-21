package com.inhatc.cs.controller;

import com.inhatc.cs.domain.Member;
import com.inhatc.cs.dto.MemberDto;
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
    public String member(Model model) throws Exception {
        Member member = new Member("서찬원", 24);
        memberRepository.insert(new MemberDto(1L,"서찬원",24));

//        model.addAttribute("member", savedMember);

        return "member";
    }
}
