<?php
    try {
        // Connexion à la database
        $pdo_options[PDO::ATTR_ERRMODE] = PDO::ERRMODE_EXCEPTION;
        $bdd = new PDO('mysql:host=localhost;dbname=RentCarAppli', 'root', '', $pdo_options);

        // Execution de la requête.
        $sql = 'SELECT * FROM voiture WHERE dispo="oui";';
        $response = $bdd->query($sql);
        $output = array();
		
		
        // Construction du fichier JSON
        while ($data = $response->fetch()) {
            $output[] = array(
                'Voiture' => utf8_encode($data['voitureNom']),
                'Marque' => utf8_encode($data['marque']),
                'Type de boîte de vitesse' => utf8_encode($data['boiteVitesse']),
				'Type d\'essence' => utf8_encode($data['typeEssence']),
				'Description' => utf8_encode($data['description']),
				'Nombre de kilomètre' => utf8_encode($data['nombreKilometre'])
            );
        }
        
        // Fermeture
        $response->closeCursor();
    } catch (Exception $e) {
        die('Erreur : ' . $e->getMessage());
    }

    // Encodage en JSON.
	header('Content-Type: application/json');
    print(json_encode($output));
?>