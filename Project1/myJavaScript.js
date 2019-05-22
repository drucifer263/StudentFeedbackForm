/*JQuery for menu burger*/
$(document).ready(function () {

    $('#nav-btn').click(function () {
        $(this).next().toggle();
    });
});//end of doc ready1

$(window).resize(function () {
    if ($(window).width() > 600)
        $('.navList').css("display", "block");
    else
        $('.navList').css("display", "none");
});//end of window
    
//Ready function 
$(document).ready(function () {
    //Validation funciton
    function formValidation() {

        //Variables
        var tuID = $("#txtTuID").val();
        var name = $("#txtName").val();

        //Checks if name is blank
        if (name == "") {
            alert("Name can not be blank");
        }
        //checks if tuid is blank
        else if (tuID == "") {
            alert("TUID can not be blank");
        }
        //checks if tuid length is less than 9
        else if (tuID.length < 9) {
            alert("TUID can not be less than 9 digits");

        }
        //checks if tuid length greater than 9
        else if (tuID.length > 9) {
            alert("TUID can not be more than 9 digits");

        } 
        //Submits form
        else {
                $("#frmStudentFeedback").submit();
        }
    }
    //Button click event
    $("#btnSubmitForm").click(function () {
        formValidation();
    }); // end of submitform button

});//end of doc ready2
/**/

