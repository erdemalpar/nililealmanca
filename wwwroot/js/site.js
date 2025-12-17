// Global State
let score = { points: 0, totalQuestions: 0 };
let currentVocabulary = [];
let currentCardIndex = 0;
let generalQuizQuestions = []; // To be loaded

// Validates keys and gets from localStoage
function loadScore() {
    const saved = localStorage.getItem('germanAppScore');
    if (saved) {
        score = JSON.parse(saved);
        updateScoreDisplay(0);
    }
}

function updateScore(pointsEarned, totalCount) {
    score.points += pointsEarned;
    score.totalQuestions += totalCount;
    localStorage.setItem('germanAppScore', JSON.stringify(score));

    updateScoreDisplay(pointsEarned);
}

function updateScoreDisplay(pointsEarned) {
    const scoreEl = document.getElementById('user-score');
    const levelEl = document.getElementById('user-level');

    if (scoreEl) {
        scoreEl.textContent = score.points;
        if (pointsEarned > 0) {
            scoreEl.classList.add('score-pulse');
            setTimeout(() => scoreEl.classList.remove('score-pulse'), 500);
        }
    }

    // Level Up logic
    const level = score.points >= 1000 ? 2 : 1;
    if (levelEl) levelEl.textContent = level;

    // Update Leaderboard user score if exists
    const userLeaderScore = document.getElementById('user-leader-score');
    if (userLeaderScore) userLeaderScore.textContent = score.points;
}

// --- Text to Speech ---
function speakText(text) {
    console.log("Speaking: " + text);
    if ('speechSynthesis' in window) {
        const utterance = new SpeechSynthesisUtterance(text);
        utterance.lang = 'de-DE';
        window.speechSynthesis.speak(utterance);
    } else {
        alert("Tarayıcınız sesli okumayı desteklemiyor.");
    }
}

// --- Vocabulary Card Logic ---
function initVocabulary(vocabData) {
    currentVocabulary = vocabData;
    updateCardDisplay();

    document.getElementById('prev-card-btn')?.addEventListener('click', () => {
        currentCardIndex = (currentCardIndex - 1 + currentVocabulary.length) % currentVocabulary.length;
        updateCardDisplay();
    });

    document.getElementById('next-card-btn')?.addEventListener('click', () => {
        currentCardIndex = (currentCardIndex + 1) % currentVocabulary.length;
        updateCardDisplay();
    });

    // Flip logic
    const cardInner = document.querySelector('#flashcard-container .transition-transform');
    document.getElementById('flashcard-container')?.addEventListener('click', () => {
        cardInner.classList.toggle('rotate-y-180');
    });
}

function updateCardDisplay() {
    if (!currentVocabulary || currentVocabulary.length === 0) return;
    const card = currentVocabulary[currentCardIndex];

    document.getElementById('card-german').textContent = card.german;
    document.getElementById('card-turkish').textContent = card.turkish;
    document.getElementById('card-example').textContent = card.example;

    // Reset flip
    const cardInner = document.querySelector('#flashcard-container .transition-transform');
    if (cardInner.classList.contains('rotate-y-180')) {
        cardInner.classList.remove('rotate-y-180');
    }

    // Start button onClick needs to be updated to capture new text, but onclick is inline. 
    // The inline onclick uses the 'speakText' global function with the hardcoded rendered value.
    // We need to update the onclick attribute for the speak button dynamically.
    const speakBtn = document.querySelector('#flashcard-container button');
    if (speakBtn) speakBtn.setAttribute('onclick', `event.stopPropagation(); speakText('${card.german}')`);

    document.getElementById('current-card-idx').textContent = currentCardIndex + 1;
}


// --- General Quiz Logic ---
let currentQuizQuestion = null;

const generalQuizQuestionsData = [
    { id: 1, type: 'translation', question: 'Guten Tag ne anlama gelir?', answer: 'İyi günler' },
    { id: 2, type: 'translation', question: 'Elma kelimesinin Almancası nedir?', answer: 'der Apfel' },
    { id: 3, type: 'translation', question: 'Zehn hangi sayıdır?', answer: 'on' },
    { id: 4, type: 'translation', question: 'Nasıl gidiyor? sorusunun Almancası nedir?', answer: 'Wie geht es Ihnen?' },
    { id: 5, type: 'translation', question: 'Ev kelimesinin Almancası nedir?', answer: 'das Haus' },
    { id: 6, type: 'translation', question: 'İçmek fiilinin Almancası nedir?', answer: 'trinken' },
    { id: 7, type: 'translation', question: 'Lütfen kelimesinin Almancası nedir?', answer: 'bitte' },
    { id: 8, type: 'translation', question: 'Teşekkürler kelimesinin Almancası nedir?', answer: 'danke' },
    { id: 9, type: 'translation', question: 'Sekiz sayısının Almancası nedir?', answer: 'acht' },
    { id: 10, type: 'translation', question: 'Gitmek fiilinin Almancası nedir?', answer: 'gehen' },
];

function initGeneralQuiz() {
    loadNewQuizQuestion();
}

function loadNewQuizQuestion() {
    const idx = Math.floor(Math.random() * generalQuizQuestionsData.length);
    currentQuizQuestion = generalQuizQuestionsData[idx];

    const qText = document.getElementById('quiz-question-text');
    const input = document.getElementById('quiz-answer-input');
    const feedback = document.getElementById('quiz-feedback');
    const btn = document.getElementById('check-answer-btn');

    if (!qText) return;

    qText.textContent = currentQuizQuestion.question;
    input.value = '';
    input.disabled = false;
    feedback.classList.add('hidden');
    btn.disabled = false;
    btn.classList.remove('opacity-50');
}

function checkGeneralQuizAnswer() {
    const input = document.getElementById('quiz-answer-input');
    const feedback = document.getElementById('quiz-feedback');
    const btn = document.getElementById('check-answer-btn');
    const val = input.value.trim().toLowerCase();

    if (!val) return;

    const correct = currentQuizQuestion.answer.toLowerCase();
    feedback.classList.remove('hidden', 'bg-green-600', 'bg-red-600', 'bg-cyan-600');

    if (val === correct) {
        feedback.textContent = "🌟 Harika! Doğru cevap.";
        feedback.classList.add('bg-green-600');
        updateScore(10, 1);
        runConfetti();
    } else {
        feedback.textContent = "Yanlış.";
        feedback.classList.add('bg-red-600');
        updateScore(0, 1);
    }

    input.disabled = true;
    btn.disabled = true;
    btn.classList.add('opacity-50');
}

function showHint() {
    const feedback = document.getElementById('quiz-feedback');
    feedback.classList.remove('hidden', 'bg-green-600', 'bg-red-600');
    feedback.classList.add('bg-cyan-600');
    feedback.textContent = "İpucu: Kelime kartlarını kontrol et. Bu bir çeviri sorusu!";
}

function runConfetti() {
    if (window.confetti) {
        window.confetti({
            particleCount: 40,
            spread: 90,
            origin: { y: 0.6 },
            colors: ['#FFC0CB', '#DA70D6', '#FFA07A', '#F0E68C', '#40E0D0']
        });
    }
}

// --- Leaderboard Mock ---
function initLeaderboard() {
    const list = document.getElementById('leaderboard-list');
    if (!list) return;

    // Generate mock leaders
    const leaders = [];
    for (let i = 1; i <= 10; i++) {
        leaders.push({ name: `Prenses P${100 + i}`, points: 0 }); // Mock points usually static/random but user passed 0 in code
    }

    // Add user
    leaders.push({ name: 'Sen', points: score.points, isUser: true });
    leaders.sort((a, b) => b.points - a.points);

    const top10 = leaders.slice(0, 11); // Show top 10 + user roughly

    list.innerHTML = '';
    top10.forEach((l, idx) => {
        const li = document.createElement('li');
        const isUser = l.isUser;
        li.className = `p-2 rounded-lg flex justify-between items-center text-sm transition duration-200 drop-shadow-sm ${idx === 0 && !isUser ? 'bg-yellow-300 text-purple-900 font-extrabold shadow-lg' :
            isUser ? 'bg-cyan-300 text-pink-800 border-2 border-cyan-500 shadow-md transform scale-[1.03]' :
                'bg-pink-200 hover:bg-pink-300 text-gray-800 border border-pink-300'
            }`;

        li.innerHTML = `
            <span class="font-mono w-1/6">${idx + 1}.</span>
            <span class="flex-1 font-semibold truncate px-1">${l.name}</span>
            <div class="text-right flex items-center space-x-2">
                 <span class="text-xs font-extrabold px-2 py-0.5 rounded-full ${l.points >= 1000 ? 'bg-purple-600 text-yellow-300' : 'bg-gray-400 text-white'}">
                    Lvl ${l.points >= 1000 ? 2 : 1}
                 </span>
                 <span class="font-extrabold text-base" ${isUser ? 'id="user-leader-score"' : ''}>${l.points}</span>
            </div>
        `;
        list.appendChild(li);
    });
}


// --- Lesson Quiz Logic ---
let lessonQuizAnswers = {};

function selectOption(questionId, option, btnElement) {
    if (btnElement.disabled) return;

    // Reset siblings
    const parent = btnElement.parentElement;
    Array.from(parent.children).forEach(b => {
        b.classList.remove('bg-cyan-300', 'text-purple-900', 'border-cyan-500', 'ring-2', 'ring-cyan-400', 'font-bold', 'shadow-md');
        b.classList.add('bg-white', 'text-gray-700', 'border-gray-300');
    });

    // Select this
    btnElement.classList.remove('bg-white', 'text-gray-700', 'border-gray-300');
    btnElement.classList.add('bg-cyan-300', 'text-purple-900', 'border-cyan-500', 'ring-2', 'ring-cyan-400', 'font-bold', 'shadow-md');

    lessonQuizAnswers[questionId] = option;

    // Check if all answered
    const lessonContainer = document.getElementById('lesson-quiz-section');
    const totalQuestions = lessonContainer.querySelectorAll('.quiz-question-block').length;
    const answeredCount = Object.keys(lessonQuizAnswers).length;

    const submitBtn = document.getElementById('submit-lesson-quiz-btn');
    if (answeredCount === totalQuestions) {
        submitBtn.disabled = false;
        submitBtn.classList.remove('bg-gray-300', 'text-gray-600', 'cursor-not-allowed');
        submitBtn.classList.add('bg-pink-600', 'text-white', 'hover:bg-pink-700', 'transform', 'hover:scale-[1.01]');
    }
}

function submitLessonQuiz() {
    const lessonContainer = document.getElementById('lesson-quiz-section');
    const questions = lessonContainer.querySelectorAll('.quiz-question-block');
    let correctCount = 0;

    questions.forEach(q => {
        const id = q.getAttribute('data-question-id');
        const correctAns = q.getAttribute('data-correct-answer');
        const userAns = lessonQuizAnswers[id];

        // Disable buttons
        const buttons = q.querySelectorAll('.quiz-option-btn');
        buttons.forEach(b => b.disabled = true);

        const feedbackArea = q.querySelector('.feedback-area');
        feedbackArea.classList.remove('hidden');

        if (userAns === correctAns) {
            correctCount++;
            feedbackArea.innerHTML = `<span class="flex items-center text-green-800 font-extrabold bg-green-100 p-3 rounded-lg border border-green-300 text-sm sm:text-base">
                      🌟 Harika!
                    </span>`;

            // Highlight correct button
            Array.from(buttons).find(b => b.textContent.trim() === userAns)
                .classList.add('bg-green-200', 'text-green-700', 'border-green-500', 'ring-4', 'ring-green-400');
        } else {
            feedbackArea.innerHTML = `<span class="flex items-center text-red-800 font-medium bg-red-100 p-3 rounded-lg border border-red-300 text-sm sm:text-base">
                      Yanlış.
                    </span>`;
            // Highlight wrong button
            if (userAns) {
                Array.from(buttons).find(b => b.textContent.trim() === userAns)
                    .classList.add('bg-red-200', 'text-red-700', 'border-red-500', 'ring-4', 'ring-red-400');
            }
        }
    });

    // Update score
    updateScore(correctCount * 10, questions.length);

    // Big fireworks confetti if all correct
    if (correctCount === questions.length) {
        var duration = 3 * 1000;
        var animationEnd = Date.now() + duration;
        var defaults = { startVelocity: 30, spread: 360, ticks: 60, zIndex: 0 };

        var interval = setInterval(function () {
            var timeLeft = animationEnd - Date.now();

            if (timeLeft <= 0) {
                return clearInterval(interval);
            }

            var particleCount = 50 * (timeLeft / duration);
            window.confetti(Object.assign({}, defaults, { particleCount, origin: { x: Math.random(), y: Math.random() - 0.2 } }));
            window.confetti(Object.assign({}, defaults, { particleCount, origin: { x: Math.random(), y: Math.random() - 0.2 } }));
        }, 250);
    }

    const submitBtn = document.getElementById('submit-lesson-quiz-btn');
    submitBtn.textContent = "Ders Tamamlandı 🎉";
    submitBtn.disabled = true;
}


// --- Init ---
document.addEventListener('DOMContentLoaded', () => {
    loadScore();

    if (window.vocabularyData) {
        initVocabulary(window.vocabularyData);
        initGeneralQuiz();
        initLeaderboard();
    }

    // Check if we are on lessons page and restore answers if we wanted to persist (optional, skip for now)

    // Reset Score Button Logic
    document.getElementById('reset-score-btn')?.addEventListener('click', () => {
        if (confirm('Puanınızı sıfırlamak istediğinize emin misiniz?')) {
            localStorage.removeItem('germanAppScore');
            location.reload();
        }
    });
});
