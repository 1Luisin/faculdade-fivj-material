package br.aula.imc;

import jakarta.servlet.ServletException;
import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import java.io.IOException;

@WebServlet(value="/calc")

public class PrimeiroServlet extends HttpServlet {

    @Override
    protected void doGet(HttpServletRequest req, HttpServletResponse resp)throws ServletException, IOException{
        System.out.println("Passei Aqui");
        String nome = req.getParameter("cpNome");
        double peso = Double.parseDouble(req.getParameter("cpPeso"));
        double altura = Double.parseDouble(req.getParameter("cpAltura"));
        double imc = peso/(altura*altura);
        resp.getOutputStream().println("<h1>IMC Web </h1>");
        resp.getOutputStream().println("<b>Olá "+nome+"."+"Você tem "+ imc+ "de imc</b>");
    }
}
