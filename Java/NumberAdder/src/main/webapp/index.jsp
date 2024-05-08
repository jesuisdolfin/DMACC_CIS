<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="ISO-8859-1">
<title>Number Adder</title>
</head>
<body>
	<h1>Number Adder</h1>
	<form action="getNumsServlet" method="post">
	Enter numbers to be added together: 
	<input type="text" name="firstNum" size="10">
	<input type="text" name="secondNum" size="10">
	<input type="submit" value="Add Numbers" />
	</form>
</body>
</html>