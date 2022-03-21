package com.inhatc.cs.repository;

import com.inhatc.cs.domain.Member;
import com.inhatc.cs.dto.MemberDto;
import lombok.RequiredArgsConstructor;
import lombok.extern.slf4j.Slf4j;
import org.springframework.jdbc.core.JdbcTemplate;
import org.springframework.jdbc.core.RowMapper;
import org.springframework.stereotype.Repository;

import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

@Slf4j
@Repository
@RequiredArgsConstructor
public class MemberRepository {

//    private Map<Long, Member> store = new HashMap<Long, Member>();
//    private long seq = 0;
//
//    public Member save(Member member) {
//        member.setId(++seq);
//        store.put(member.getId(), member);
//
//        return member;
//    }
//
//    public Member findById(Long id) {
//        return store.get(id);
//    }
//
//    public List<Member> findAll() {
//        return new ArrayList<Member>(store.values());
//    }

    private final JdbcTemplate jdbcTemplate;

    /**
     * DB데이블을 생성하는 메소드
     */
    public void createDB() throws Exception{
        log.info("Repo --- createDB");
        String query =  "create table member(" +
                "username varchar(20)," +
                "id int not null primary key," +
                "age int)" +
                "DEFAULT CHARSET=utf8;";
        jdbcTemplate.execute(query);
    }

    public void dropDB() throws Exception{
        log.info("Repo --- dropDB");
        String query =  "drop table member";
        jdbcTemplate.execute(query);
    }

    public int insert(MemberDto memberDto) throws Exception{
        //메소드 불러올 때 로그를 남김
        log.info("Repo --- insert");
        //쿼리문을 적고 실행하고 리턴한다.(insert는 update)
        return jdbcTemplate.update(
                "insert into member(username,id,age) values (?,?,?);"
                ,memberDto.getUsername(),memberDto.getId(),memberDto.getAge());
    }

    public MemberDto findById(Long id) {
        log.info("Repo --- select by id");

        List<MemberDto> results = jdbcTemplate.query(
                "select * from member where id = ?",
                new RowMapper<MemberDto>() {
                    @Override
                    public MemberDto mapRow(ResultSet resultSet, int i) throws SQLException {
                        MemberDto memberDto = new MemberDto();
                        memberDto.setUsername(resultSet.getString("username"));
                        memberDto.setId(Long.valueOf(resultSet.getInt("id")));
                        memberDto.setAge(resultSet.getInt("age"));
                        return memberDto;
                    }
                },id);

        return results.isEmpty() ? null : results.get(0);
    }
}
