var clock = document.querySelector('.viewCurrentTime');

function getTime() {
    const time = new Date();
    const year = time.getFullYear();
    const month = time.getMonth()+1;
    const date = time.getDate();
    const hour = time.getHours();
    const minutes = time.getMinutes();
    const seconds = time.getSeconds();
    clock.innerHTML = `현재 접속 시각 : ${year}년 ${month}월 ${date}일 ${hour<10 ? `0${hour}`:hour}:${minutes<10 ? `0${minutes}`:minutes}:${seconds<10 ? `0${seconds}`:seconds}`;
}

function init() {
    getTime();
    setInterval(getTime, 1000);
}

init();