// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


$(document).ready(function () {

    var name = $(".LoginName").text().toString();


/*    $name.hide();
*/

    console.log(name);
    $("tr").hide()

    $("tr:contains('"+name+"')").show();

    /*  if ($("tr").text() == (name) ) {


          $("tr:contains('"+name+"')").hide();


          ($("tr").text() == (name)).hide();
      }*/

    /*$("tr").hide().filter($(":contains(name)")).show();*/
    /*  .parent().filter("tr")*/


});