---  
categories: blog  
title: தமிழ் நாட்காட்டி
keywords: More, Tamil, Books  
description: தமிழ் நாட்காட்டி jquery-ui plugin Model
author: Tamilan  
layout: Ruby  
tags:     
- நாட்காட்டி
permalink: datepicker_ta  
featured: /images/noolkal_96_6.png  
---  
## ஆங்கில நாட்காட்டியின் மாதிரி வடிவம்

<div id="datepicker"></div>

## தமிழ் நாட்காட்டியின் மாதிரி வடிவம்
<div id="datepicker_ta"></div>

## இனிய தளங்களில் பயன்படுத்தும் முறை

### At head section of your file

	<!doctype html>
	<html lang="en">
	<head>
	  <meta charset="utf-8">
	  <meta name="viewport" content="width=device-width, initial-scale=1">
	  <title>jQuery UI Datepicker - Default functionality</title>
	  <link rel="stylesheet" href="//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css">
	  <link rel="stylesheet" href="/resources/demos/style.css">
	  <script src="https://code.jquery.com/jquery-1.12.4.js"></script>
	  <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>
	  <script>
	  $( function() {
		$( "#datepicker" ).datepicker();
	  } );
	  </script>
	</head>
	<body>
	 
	<p>Date: <input type="text" id="datepicker"></p>
	 
	 
	</body>
	</html>

<script>
$(function(){

$( "#datepicker" ).datepicker({
	inline: true
});

$( "#datepicker_ta" ).datepicker_ta({
	inline: true
});

});
</script>