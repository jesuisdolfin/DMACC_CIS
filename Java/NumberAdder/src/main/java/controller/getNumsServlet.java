package controller;

import java.io.IOException;
import java.io.PrintWriter;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import model.NumberAdder;

/**
 * Servlet implementation class getNumsServlet
 */
@WebServlet("/getNumsServlet")
public class getNumsServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public getNumsServlet() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		String firstNum = request.getParameter("firstNum");
		String secondNum = request.getParameter("secondNum");
		
		NumberAdder userNums = new NumberAdder(Integer.parseInt(firstNum), Integer.parseInt(secondNum));
		
		request.setAttribute("userNumbers", userNums);

		getServletContext().getRequestDispatcher("/result.jsp").forward(request, response);
		
		PrintWriter writer = response.getWriter();
		writer.println(userNums.printResult());
		writer.close();
	}

}
