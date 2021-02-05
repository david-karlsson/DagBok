// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


$(document).ready(function () {

    var name = $(".LoginName").text();
    /*var date = $(".datum-text");*/

/*    $name.hide();
*/
/*
    console.log(name);*/
    $("tr").hide();
    $("tr:contains('" + name + "')").show();
/*    $(date).show();
*/    $("#TableHeadRow").show();









    $("tr").click(function () {

        $("td", this).css("display", "inline-block");

/*     $("td", this).toggleClass("webkit-box-display");*/

      /*  var display = $("td", this).css("display");
         
        if (display === "inline-block"){

            $("td", this).css("display", "-webkit-box");


        }


        if (display === "-webkit-box") {

            $("td", this).css("display", "inline-block");


        }*/






/*

        if ($("td", this).attr === "display", "-webkit-box") {

            $("td", this).css("display", "inline-block");
*/


    /*  }*/


/*
        $(".td", this).addClass("td-inline");*/
        
      /*  if ($("tr", this.children).hasClass("webkit-box-display"))
            {
          

            }

        else
            {
                $("td", this).addClass("webkit-box-display");

            }*/




        if ($("td",this).hasClass("invisible")) {


            $(".invisible", this).addClass("visible");
            $(".invisible", this).removeClass("invisible");


        }
        else if ($("td", this).hasClass("visible")) {

            $(".visible", this).addClass("invisible");
            $(".visible",this).removeClass("visible");
        }
/*
      

    


        $("td").hasClass("visible")
        {
        };*/




    });


    /*  if ($("tr").text() == (name) ) {


          $("tr:contains('"+name+"')").hide();


          ($("tr").text() == (name)).hide();
      }*/

    /*$("tr").hide().filter($(":contains(name)")).show();*/
    /*  .parent().filter("tr")*/


});