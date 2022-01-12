
// часть 1
let inputs = document.querySelectorAll('input.input__file2, input.input__file1, input.input__file3');
    console.log(inputs);
[].forEach.call(inputs, function (one_input) {

    let my_label = one_input.nextElementSibling;
    labelVal = my_label.querySelector('.input__file-button-text').innerText;

    one_input.addEventListener('change', function (e) {
        let countFiles = '';
        if (this.files && this.files.length >= 1)
            countFiles = this.files.length;

        if (countFiles)
            my_label.querySelector('.input__file-button-text').innerText = this.files[0].name;
        else
            my_label.querySelector('.input__file-button-text').innerText = labelVal;
    });
});

//часть 2

let dropArea12 = document.querySelectorAll("div#drop-area1, div#drop-area2, div#drop-area3");
// сброс обработчика по умолчанию
;['dragenter', 'dragover', 'dragleave', 'drop'].forEach(eventName => {
    document.body.addEventListener(eventName, preventDefaults, false)
})

function preventDefaults(e) {
    e.preventDefault()
    e.stopPropagation()
}
[].forEach.call(dropArea12, function (dropArea) {
    console.log('ok1')

    // индикатор перетаскивания
    ;['dragenter', 'dragover'].forEach(eventName => {
        dropArea.addEventListener(eventName, highlight, false)
    })

    ;['dragleave', 'drop'].forEach(eventName => {
        dropArea.addEventListener(eventName, unhighlight, false)
    })

    function highlight(e) {
        dropArea.classList.add('highlight')
    }

    function unhighlight(e) {
        dropArea.classList.remove('highlight')
    }

    // перетаскивание файла
    dropArea.addEventListener('drop', handleDrop, false)

    function handleDrop(e) {
        var dt = e.dataTransfer
        var files = dt.files
        handleFiles(files)
    }
    //к каждому files испольщуем uploadFile
    function handleFiles(files) {
        ([...files]).forEach(uploadFile)
    }

    function uploadFile(file) {
        let my_label = dropArea.querySelector('.input__file-button-text');
        console.log(my_label.innerText);
        my_label.innerText = file.name;
     };

});