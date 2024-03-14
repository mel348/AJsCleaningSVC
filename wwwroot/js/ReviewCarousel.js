function carousel(review) {
    let reviews = document.getElementsByClassName("review__items");

    for (let i = 0; i < reviews.length; i++) {
        reviews[i].style.display = "none";
    }
    reviews[review].style.display = "block";
}

function previousReview() {
    let rev = document.querySelectorAll('.review__items');

    for (let i = 0; i < rev.length; i++) {
        if (rev[i].style.display == 'block') {
            rev[i].style.display = 'none';
            if (i == 0) {
                rev[rev.length - 1].style.display = 'block';
                break;
            } else {
                rev[i - 1].style.display = 'block';
                break;
            }
        }
    }
}

function nextReview() {
    let rev = document.querySelectorAll('.review__items');

    for (let i = 0; i < rev.length; i++) {
        if (rev[i].style.display == 'block') {
            rev[i].style.display = 'none';
            if (i == rev.length - 1) {
                rev[0].style.display = 'block';
                break;
            } else {
                rev[i + 1].style.display = 'block';
                break;
            }
        }
    }
}
