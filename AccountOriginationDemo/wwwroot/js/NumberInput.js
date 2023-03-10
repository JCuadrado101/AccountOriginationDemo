let number = document.getElementsByClassName("input-number");

function addCommaToNumberInput() {
    for (let i = 0; i < number.length; i++) {
        number[i].addEventListener("keypress", function (evt) {
            if (number[i].value.length == 0 && evt.which == 48) {
                evt.preventDefault();
                number[i].value.slice(0, 0);
            } else if (evt.which != 8 && evt.which != 0 && evt.which < 48 || evt.which > 57) {
                evt.preventDefault();
            }
        });
    }
}
