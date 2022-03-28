package com.inhatc.cs.repository;

import com.inhatc.cs.domain.MemberVO;
import lombok.RequiredArgsConstructor;
import org.apache.ibatis.session.SqlSession;
import org.springframework.stereotype.Repository;

@Repository
@RequiredArgsConstructor
public class MemberDAOImpl implements MemberDAO{

    private final SqlSession sqlSession;
    private static final String namespace = "com.inhatc.mapper.MemberMapper";

    @Override
    public String getTime() {
        return sqlSession.selectOne(namespace + ".getTime");
    }

    @Override
    public void insertMember(MemberVO memberVO) {
        sqlSession.selectOne(namespace + ".insertMember",memberVO);
    }
}
