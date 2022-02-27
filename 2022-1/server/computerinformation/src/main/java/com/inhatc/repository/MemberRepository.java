package com.inhatc.repository;

import com.inhatc.domain.Member;

import java.util.HashMap;
import java.util.Map;

public interface MemberRepository {
    public Member save(Member member);

    public Member findById(Long id);
}
