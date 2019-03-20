//Couunt the number
$('.count').each(function() 
{
    $(this).prop('Counter',0).animate(
    {
        Counter: $(this).text()
    }, 
    {
        duration: 4000,
        easing: 'swing',
        step: function(now) 
        {
            $(this).text(Math.ceil(now));
        }
    });
});

//card gioi-thieu
$('.gioithieu-card').on('click', function () 
{
    $('.card').toggleClass('flipped');
});


