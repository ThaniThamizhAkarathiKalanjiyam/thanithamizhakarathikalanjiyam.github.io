$(document).ready(function () {

    var searchBaseUrl = "https://thanithamizhakarathikalanjiyam.github.io/"

        $.ajaxSetup({
            beforeSend: () => {
                $("#loading").show();
            },
            complete: () => {
                $("#loading").hide();
            }
        });

    var searchUrls = [];

    var converter = new showdown.Converter();

    wordsearch = function (funcData) {

        var searctTextVal = $.trim($("#txtsearch").val().toLowerCase())

            $.get(funcData.url + searctTextVal,
                function (ResponseJsonE) {

                //<div id="accordion">
                var accordionDiv = $("<div>")
                    accordionDiv.attr("id", "accordion")

                    //$.each(ResponseJsonE, function (index, value)
                {

                    //<h3>Section 1</h3>
                    var h3Div = $("<h3>")
                        $(h3Div).html(funcData.dict_full)
                        $(accordionDiv).append(h3Div)
                        //<div>
                        //<p>
                        //Mauris mauris ante, blandit et, ultrices a, suscipit eget, quam. Integer
                        //ut neque. Vivamus nisi metus, molestie vel, gravida in, condimentum sit
                        //amet, nunc. Nam a nibh. Donec suscipit eros. Nam mi. Proin viverra leo ut
                        //odio. Curabitur malesuada. Vestibulum a velit eu ante scelerisque vulputate.
                        //</p>
                        var htmlVal = converter.makeHtml(value.dictionary_meaning);
                    var pDiv = $("<p>")
                        pDiv.html(htmlVal)
                        $(accordionDiv).append(pDiv)
                        //</div>
                        //</div>

                }
                //)
                $("#meanings").append(accordionDiv)
                //$( "#accordion" ).accordion();

            });

    }

    updateSearchWords = function (txtsearchLow) {

        if (txtsearchLow !== undefined) {

            var utf_txtsearchLow = decodeURIComponent(txtsearchLow);

            $.ajax({
                url: 'https://docs.google.com/forms/d/e/1FAIpQLSfHQVgPZRpRq2Fegi9LFoibfNtCjLzufxCdqQYqlhL81VnkVA/formResponse',
                type: 'POST',
                dataType: 'jsonp',
                data: {
                    "entry.891892085": utf_txtsearchLow,
                    "entry.1113699608": utf_txtsearchLow,
                    "submit": "Submit",
                    "origin": "*"
                },
                success: function (ResponseJsonE) {},
                error: function () {}
            });

        }

    };

    init_getJSON = function () {
        $.getJSON("https://thanithamizhakarathikalanjiyam.github.io/ttakJs/urls.json", function (url_data) {
			searchUrls = url_data
            
            console.log(searchUrls)
        });
    }

    $("#btnSearch").click(function () {
        $("#meanings").html("")

        $.each(searchUrls, function (index, value) {
            wordsearch({
                url: value.dir,
                dict_full: value.dict_full
            })
        })

        var searctTextVal = $.trim($("#txtsearch").val().toLowerCase())
            updateSearchWords(searctTextVal)

    })
 
    var jqxhr = $.when(init_getJSON())
		.then(function () {
			
		})
        .done(function () {
            //versol_div("வேர்", ["இடது கிளை", "வலது கிளை"]);
            //$('#jstree_demo_div').jstree();
            // side_extra_info();
        });
    // Set another completion function for the request above
    jqxhr.always(function () {});

})
