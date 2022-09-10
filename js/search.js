$(document).ready(function(){

 wordsearch = function (funcData) {
	 
	 var searctTextVal = $.trim($("#txtSearch").val().toLowerCase())
		
	 
	 $.getJSON('https://effervescent-babka-d3abb0.netlify.app/json/'+searctTextVal, function(ResponseJsonE) {
    
//<div id="accordion">
var accordionDiv  = $("<div>")
accordionDiv.attr("id","accordion")

$.each(ResponseJsonE,function(index,value){
	
//<h3>Section 1</h3>
var h3Div = $("<h3>")
$(h3Div).html(value.dictionary_name)
$(accordionDiv).append(h3Div)
//<div>
//<p>
//Mauris mauris ante, blandit et, ultrices a, suscipit eget, quam. Integer
//ut neque. Vivamus nisi metus, molestie vel, gravida in, condimentum sit
//amet, nunc. Nam a nibh. Donec suscipit eros. Nam mi. Proin viverra leo ut
//odio. Curabitur malesuada. Vestibulum a velit eu ante scelerisque vulputate.
//</p>
var pDiv = $("<p>")
pDiv.html(value.dictionary_meaning)
$(accordionDiv).append(pDiv)
//</div>
//</div>  
	
})

		
		  $("#meanings").html(accordionDiv)
		  $( "#accordion" ).accordion();
		  
});
	 		
     
		updateSearchWords(searctTextVal)
	}

 updateSearchWords = function (txtsearchLow) {
		 
		 if(txtsearchLow !== undefined){
			 
		 var utf_txtsearchLow = decodeURIComponent(txtsearchLow);
		 
        $.ajax({
            url: 'https://docs.google.com/forms/d/e/1FAIpQLSfHQVgPZRpRq2Fegi9LFoibfNtCjLzufxCdqQYqlhL81VnkVA/formResponse',
            type: 'POST',
            dataType: 'jsonp',
            data: {
				"entry.891892085":utf_txtsearchLow,
				"entry.1113699608":utf_txtsearchLow,
				"submit":"Submit",
				"origin":"*"
			},
            success: function (ResponseJsonE) {
                
            },
            error: function () {
                
            }
        });
    
		 }
	
	};
	
	
	
$("#btnSearch").click(function(){

wordsearch()
	
})


})