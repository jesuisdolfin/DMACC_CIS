<%@ page language="java" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<!DOCTYPE html>
<html>
<head>
<meta charset="ISO-8859-1">
<title>Results</title>
</head>
<body>
<p>
${userNumbers.getFirstNum()} + <br />
${userNumbers.getSecondNum()} = <br />
${userNumbers.getSum()} ! <br />
</p>
<a href="index.jsp">Go again?</a>
</body>
</html>