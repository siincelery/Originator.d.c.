const toggleButtons = document.querySelectorAll('.toggle-button'); // Получаем все кнопки
const hiddenTexts = document.querySelectorAll('.hidden-text'); // Получаем все блоки с текстом

toggleButtons.forEach((button, index) => { // Проходим по каждой кнопке
    button.addEventListener('click', () => {
        if (hiddenTexts[index].style.display === 'none') {
            hiddenTexts[index].style.display = 'block';
            button.textContent = '–';
        } else {
            hiddenTexts[index].style.display = 'none';
            button.textContent = '+';
        }
    });
});