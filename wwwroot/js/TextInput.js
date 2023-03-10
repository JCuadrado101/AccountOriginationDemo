function limitInputToLetters() {
    let input = document.getElementsByClassName("text-input");
    for (let i = 0; i < input.length; i++) {
        input[i].oninput = function () {
            input[i].value = input[i].value.replace(/[^a-zA-Z- ']/g, '');
        }
    }
}