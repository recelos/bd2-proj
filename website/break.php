<?php
    // Get a random meme from an API
    $json = file_get_contents('https://api.imgflip.com/get_memes');
    $data = json_decode($json);
    $random_meme = $data->data->memes[array_rand($data->data->memes)];
echo '<div style="font-size: 20px;">Sorka :<, aktualnie rejestracja jest wyłączona, aby chronić nasze zasoby przed ruskimi.</div>';
    // Start a div container for centering the image
    echo '<div style="text-align: center;">';

    // Display the random meme
    echo '<img src="' . $random_meme->url . '" alt="' . $random_meme->name . '" style="margin: 0 auto; max-width: 500px; max-height: 500px;" />';

    // Close the div container
    echo '</div>';

    // Print information about a technical break
    echo '<br><br>';
echo '<div style="text-align: center;">';
    echo '<img src="/teu83um39sh61.webp"  max-width: 300px;>';
    echo '</div>';
?>
