package com.inhatc.cs.controller;

import com.inhatc.cs.service.LottoGenerator;
import lombok.extern.slf4j.Slf4j;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;

@Slf4j
@Controller
public class GugudanController {

    private LottoGenerator lottoGenerator = new LottoGenerator();

    @GetMapping("/gugudan")
    public String get(Model model) {
        log.info("print gugudan");
        return "gugudan";
    }

    @GetMapping("/lotto")
    public String lotto(Model model) {
        log.info("print lotto");
        int[] lotto = lottoGenerator.testNumber();
        model.addAttribute("lotto", lotto);
        return "lotto";
    }
}
