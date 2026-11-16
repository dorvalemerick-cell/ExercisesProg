#!/bin/bash




Main(){
	while true
	do
		AskName
		AskAge
		EndMessage
	done
}

AskName()
{
	read -p "Entrez votre nom (Q pour quitter): " NOM
	return $NOM
}

AskAge () 
{
	read -p "Entrez votre age (Q pour quitter): " AGE
	return $AGE
}

EndMessage()
{
	echo "Bonjour $NOM tu as $AGE ans!"
}

Main
