package com.inhatc.domain;

import org.springframework.web.util.UriComponents;
import org.springframework.web.util.UriComponentsBuilder;

public class PageMaker {

  private int totalCount;
  private int startPage;
  private int endPage;
  private boolean prev;
  private boolean next;

  private int displayPageNum = 10;

  private Criteria cri;

  public void setCri(Criteria cri) {
    this.cri = cri;
  }

  public void setTotalCount(int totalCount) {
    this.totalCount = totalCount;

    calcData();
  }

//  확인 1
  private void calcData() {

    /**
     *      1 ~ 10
     * ex1) page=7 -> ceil(0.7) -> 1 * 10 -> 10
     *      11 ~ 20
     * ex2) page=11 -> ceil(1.1) -> 2 * 10 -> 20
     */
    endPage = (int) (Math.ceil(cri.getPage() / (double) displayPageNum) * displayPageNum);

    /**
     * ex1) 10 - 10 + 1 -> 1
     * ex2) 20 - 10 + 1 -> 11
     */
    startPage = (endPage - displayPageNum) + 1;

    /**
     * ex1) 전체 게시물 개수 311, perPageNum = 10, 총 보여줘야할 페이지 수 -> 32
     *      ceil(31.1) -> 32
     * ex2) 전체 게시물 개수 220, perPageNum = 10, 총 보여줘야할 페이지 수 -> 22
     *      ceil(22) -> 22
     */
    int tempEndPage = (int) (Math.ceil(totalCount / (double) cri.getPerPageNum()));

    if (endPage > tempEndPage) {
      endPage = tempEndPage;
    }

    prev = startPage == 1 ? false : true;

    next = endPage * cri.getPerPageNum() >= totalCount ? false : true;

  }

  public int getTotalCount() {
    return totalCount;
  }

  public int getStartPage() {
    return startPage;
  }

  public int getEndPage() {
    return endPage;
  }

  public boolean isPrev() {
    return prev;
  }

  public boolean isNext() {
    return next;
  }

  public int getDisplayPageNum() {
    return displayPageNum;
  }

  public Criteria getCri() {
    return cri;
  }

//  확인 2
  public String makeQuery(int page) {

    //?page=&perPageNum=
    UriComponents uriComponents = UriComponentsBuilder.newInstance().queryParam("page", page)
        .queryParam("perPageNum", cri.getPerPageNum()).build();

    return uriComponents.toUriString();
  }
  
  
  public String makeSearch(int page){
    
    UriComponents uriComponents =
              UriComponentsBuilder.newInstance()
              .queryParam("page", page)
              .queryParam("perPageNum", cri.getPerPageNum())
              .queryParam("searchType", ((SearchCriteria)cri).getSearchType())
              .queryParam("keyword", ((SearchCriteria)cri).getKeyword())
              .build();             
    
    return uriComponents.toUriString();
  } 
}
