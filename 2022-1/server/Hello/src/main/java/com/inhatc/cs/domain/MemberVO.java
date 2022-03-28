package com.inhatc.cs.domain;

import lombok.Data;
import lombok.NoArgsConstructor;

import java.util.Date;

@Data
@NoArgsConstructor
public class MemberVO {

    private String userId;
    private String username;
    private String userPw;
    private String email;
    private Date regDate;
    private Date updateDate;

    public MemberVO(String userId, String username, String userPw, String email) {
        this.userId = userId;
        this.username = username;
        this.userPw = userPw;
        this.email = email;
    }
}
