$(document).ready(function () {

    $('#sidebarCollapse').on('click', function () {
        $('#sidebar').toggleClass('active');
    });

});

$('.rolldown-list li').each(() => {
    let delay = ($(this).index() / 4) + 's';
    $(this).css({
        webkitAnimationDelay: delay,
        mozAnimationDelay: delay,
        animationDelay: delay
    });
});

$('#btnReload').click(function () {
    $('#myList').removeClass('rolldown-list');
    setTimeout(function () {
        $('#myList').addClass('rolldown-list');
    }, 1);
});

$("input:checkbox").on('click', function () {
    // in the handler, 'this' refers to the box clicked on
    var $box = $(this);
    if ($box.is(":checked")) {
        // the name of the box is retrieved using the .attr() method
        // as it is assumed and expected to be immutable
        var group = "input:checkbox[id='" + $box.attr("id") + "']";
        // the checked state of the group/box on the other hand will change
        // and the current value is retrieved using .prop() method
        $(group).prop("checked", false);
        $box.prop("checked", true);
    } else {
        $box.prop("checked", false);
    }
});

//$(document).ready(function () { 
//    var $box = $(this);
    
//});

//$(document).ready(function () {
//    $('.check').click(function () {
//        $('.check').not(this).prop('checked', false);
//    });
//});


function giveAnswer(questionId, ansewrId) {
    console.log(questionId + " " + ansewrId);
    let ul = document.getElementById(`question_${questionId}`);
    let lis = ul.children;
    
    for (let i = 0; i < lis.length; i++) {
        
        lis[i].style.background = "white";
    }

    let li = document.getElementById(`question_${questionId}_answer_${ansewrId}`);
    li.style.background = 'lightyellow';
    let input = document.getElementById(`input_${questionId}_question_${ansewrId}`);
    input.checked = true;
}
