<%@ page language="java" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<!DOCTYPE html>
<html>
<head>
<meta charset="ISO-8859-1">
<title>Insert title here</title>
</head>
<body>
	<form action="editPlayerServlet" method="post">
	Name: <input type="text" name="name" value="${toEdit.name}">
	Number: <input type="text" name="number" value="${toEdit.number}">
	Position: <input type="text" name="position" value="${toEdit.position}">
	<input type="hidden" name="id" value="${toEdit.id}">
	<input type="submit" value="Save Edited Player">
	</form>
</body>
</html>