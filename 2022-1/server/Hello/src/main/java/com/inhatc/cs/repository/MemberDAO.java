package com.inhatc.cs.repository;

import com.inhatc.cs.domain.MemberVO;

public interface MemberDAO {

    public String getTime();

    public void insertMember(MemberVO memberVO);
}
