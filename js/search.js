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

            for (i = 0; i < url_data.length; i++) {
                //var id = url_data[i].id;
                var dict = url_data[i].dict;
                var dict_full = url_data[i].dict_full;
                //var desc = url_data[i].desc;
                //var kaan = url_data[i].kaan;
                var dir = url_data[i].kaan;
                var getAllUrlParams_url = window.location.href;
                //var kaan_url = getAllUrlParams(getAllUrlParams_url).kaan;
                var loc_url  = searchBaseUrl + dir
                searchUrls.push({
                    url: loc_url,
                    dict_full: dict_full,
					dir:dir
                })
            }
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
