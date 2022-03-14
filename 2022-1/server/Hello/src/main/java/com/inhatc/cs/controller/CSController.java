package com.inhatc.cs.controller;

import com.inhatc.cs.domain.ProductVO;
import lombok.extern.slf4j.Slf4j;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.ResponseBody;
import org.springframework.web.servlet.mvc.support.RedirectAttributes;

@Slf4j
@Controller
public class CSController {

    @GetMapping("/doA")
    public void doA(@RequestParam String username) {
        int sum = 0;
        for (int i = 1; i <= 10; i++) {
            sum += i;
        }
        log.info("{}", username);
        log.info("CSController.doA");
        log.info("{}", sum);
    }

    @GetMapping("/doB")
    public void doB() {
        log.info("CSController.doB");
    }

    @GetMapping("/doC")
    public String doC(@ModelAttribute("msg") String msg) {
        log.info("CSController.doC");
        return "result";
    }

    @GetMapping("/doD")
    public String doD(@ModelAttribute ProductVO productVO) {
        log.info("CSController.doD");
        return "productDetail";
    }

    @GetMapping("/doE")
    public String doE(RedirectAttributes redirectAttributes) {
        log.info("doE call => redirect:/doF");

        redirectAttributes.addAttribute("msg", "redirected");

        return "redirect:/doF";
    }

    @ResponseBody
    @GetMapping("/doF")
    public String doF(String msg) {
        log.info("doF called -> {}",msg);

        return msg;
    }

    @GetMapping("/doJSON")
    public @ResponseBody ProductVO doJSON() {
        return new ProductVO("제품명", 10000);
    }
}
