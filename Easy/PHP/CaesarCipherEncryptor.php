<?php

namespace Easy\PHP\CaesarCipherEncryptor;

class Encrypt
{
    public $ENGLISH_ALPHABET = 26;
    public $output;

    public function encrypt($str, $key)
    {

        for ($i = 0; $i < strlen($str); $i++) {
            if (ctype_lower($str[$i])) {
                $character = (ord($str[$i]) - ord('a') + $key) % $this->ENGLISH_ALPHABET + ord('a');
                $this->output .= chr($character);
            } else {
                $character = (ord($str[$i]) - ord('A') + $key) % $this->ENGLISH_ALPHABET + ord('A');
                $this->output .= chr($character);
            }
        }

        return $this->output;
    }
}


$str = "shajklxyz";
$key = 2;
$encrypt  = new Encrypt();
$result = $encrypt->encrypt($str, $key);
print_r($result);
