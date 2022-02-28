package com.inhatc.cs.repository;

import com.inhatc.cs.domain.Member;
import org.springframework.stereotype.Repository;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

@Repository
public class MemberRepository {

    private Map<Long, Member> store = new HashMap<Long, Member>();
    private long seq = 0;

    public Member save(Member member) {
        member.setId(++seq);
        store.put(member.getId(), member);

        return member;
    }

    public Member findById(Long id) {
        return store.get(id);
    }

    public List<Member> findAll() {
        return new ArrayList<Member>(store.values());
    }
}
