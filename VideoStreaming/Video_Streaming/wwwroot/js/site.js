﻿// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {
    // vid select
    $('.thumbnail').click(function () {
        const videoId = $(this).data('video-id');
        $('#currentVideo').attr('src', 'https://www.youtube.com/embed/' + videoId);

        // Vid title and desc...
        const titles = {
            'vtpwM1KtWMA': 'Just The 3 Of Us',
            '9o5wD6KdoF4': 'Way Back Home',
            'mgVbToNE9mE': 'I Love You, Hater',
            '9UNbFfSzaE8': 'Can\'t Help Falling in Love',
            'uIdN3yCQLdM': 'She\'s Dating the Gangster',
            '2QwUESzFig0': 'Diary ng Panget',
            'Yo9emir5wbU': 'Four Sisters and a Wedding',
            'cit1mm96w30': 'Loving in Tandem',
            'NBL8xGp3vx0': 'Block Z',
            'lTwPhcFOutU': 'Beauty and The Bestie'
        };

        const descriptions = {
            'vtpwM1KtWMA': 'The film revolves around Uno Abusado and CJ Manalo who are both involved in the airline industry. The former is an airline pilot who aspires to be a captain and the latter is part of the ground crew who aspires to be a flight attendant. After a one night stand the two were forced to live together to deal with each others contrasting personalities with Manalo now pregnant and claiming that Abusado is the father of her unborn child.',
            '9o5wD6KdoF4': 'Jessica and Joanna, two sisters who were separated as toddlers, meet again during a swimming contest, re-igniting old jealousies between the two after their twelve years apart have transformed them into different people.',
            'mgVbToNE9mE': 'Joko and Zoey, two people struggling to make it through life, compete for a chance to work as a personal assistant. Along the way, they grow close and form a special bond with one another.',
            '9UNbFfSzaE8': 'Gab becomes engaged to her long-time boyfriend Jason and discovers that she is already married, but to a total stranger, the happy-go-lucky Dos.',
            'uIdN3yCQLdM': 'Athena Dizon plays a trick on campus heartthrob and bad boy, gangster, Kenji de los Reyes. Setting up an arrangement to pretend as lovers-to make his ex jealous-they found themselves falling to each other yet falling apart.',
            '2QwUESzFig0': 'A poor young woman becomes a personal maid for a rich and handsome young man. The two do not get along at first, but as their lives become entangled, their relationship becomes more complicated.',
            'Yo9emir5wbU': 'Four sisters try to stop their younger brother\'s wedding; in the process, all discover resentments among one another.',
            'cit1mm96w30': 'Loving In Tandem follows the story of Shine, a positive and determined girl who will do everything for her family. She meets the balikbayan Luke in the most unusual circumstance and later on finds herself experiencing various stages of love – as they get closer.',
            'NBL8xGp3vx0': 'A group of university students must band together in order to survive a deadly viral disease outbreak.',
            'lTwPhcFOutU': 'For an important case, a policeman needs the help of his former best friend to impersonate the daughter of a foreign dignitary in a beauty pageant.'
        };

        $('#videoTitle').text(titles[videoId]);
        $('#movieDescription').text(descriptions[videoId]);
    });

    // For toggling visibility
    $('#descriptionButton').click(function () {
        $('#descriptionContent').toggleClass('hidden');
    });


    $('#favoriteButton').click(function () {
        $(this).toggleClass('favorited');
        if ($(this).hasClass('favorited')) {
            const currentTitle = $('#videoTitle').text();
            const currentVideoId = $('#currentVideo').attr('src').split('/').pop();
            $('#favoritesList').append(`<p data-video-id="${currentVideoId}">${currentTitle}</p>`);
        } else {
            const currentVideoId = $('#currentVideo').attr('src').split('/').pop();
            $(`#favoritesList p[data-video-id="${currentVideoId}"]`).remove();
        }
    });

    // For navigations
    $('#favoritesButton').click(function () {
        $('.container > div').addClass('hidden');
        $('#favoritesList').removeClass('hidden');
    });

    $('#profileButton').click(function () {
        $('.container > div').addClass('hidden');
        $('#profileContent').removeClass('hidden');
    });

    // Search functionality
    $('#searchButton').click(function () {
        const query = $('#searchBar').val().toLowerCase();
        $('.thumbnail').each(function () {
            const title = $(this).find('img').attr('alt').toLowerCase();
            if (title.includes(query)) {
                $(this).show();
            } else {
                $(this).hide();
            }
        });
    });
});

