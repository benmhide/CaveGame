using UnityEngine;

// Holds all the colour values for ease of access
public static class Colours
{
    // FLOOR COLOURS
    public static Color floorColour = new Color(191.0f / 255.0f, 171.0f / 225.0f, 133.0f / 255.0f); // SET COLOUR NORMAL
    public static Color floorColourRedSafe = new Color(191.0f / 255.0f, 171.0f / 225.0f, 133.0f / 255.0f);
    public static Color floorColourGreenSafe = new Color(204.0f / 255.0f, 204.0f / 255.0f, 204.0f / 255.0f);
    public static Color floorColourBlueSafe = new Color(204.0f / 255.0f, 204.0f / 255.0f, 204.0f / 255.0f); //

    // EDGE COLOURS
    public static Color edgeColour = new Color(48.0f / 255.0f, 48.0f / 255.0f, 48.0f / 255.0f); // SET NORMAL COLOUR
    public static Color edgeColourRedSafe = new Color(48.0f / 255.0f, 48.0f / 255.0f, 48.0f / 255.0f);
    public static Color edgeColourGreenSafe = new Color(45.0f / 255.0f, 31.0f / 255.0f, 0.0f / 255.0f);
    public static Color edgeColourBlueSafe = new Color(45.0f / 255.0f, 31.0f / 255.0f, 0.0f / 255.0f); //

    // BORDER COLOURS
    public static Color borderColour = new Color(edgeColour.r, edgeColour.g, edgeColour.b); // SET NORMAL COLOUR - COPIED FROM ABOVE
    public static Color borderColourRedSafe = new Color(edgeColourRedSafe.r, edgeColourRedSafe.g, edgeColourRedSafe.b);
    public static Color borderColourGreenSafe = new Color(edgeColourGreenSafe.r, edgeColourGreenSafe.g, edgeColourGreenSafe.b);
    public static Color borderColourBlueSafe = new Color(edgeColourBlueSafe.r, edgeColourBlueSafe.g, edgeColourBlueSafe.b);

    // ROCK COLOURS
    public static Color rockColour = new Color(117.0f / 255.0f, 95.0f / 255.0f, 43.0f / 255.0f); // SET NORMAL COLOUR
    public static Color rockColourRedSafe = new Color(117.0f / 255.0f, 95.0f / 255.0f, 43.0f / 255.0f);
    public static Color rockColourGreenSafe = new Color(61.0f / 255.0f, 61.0f / 255.0f, 61.0f / 255.0f);
    public static Color rockColourBlueSafe = new Color(61.0f / 255.0f, 61.0f / 255.0f, 61.0f / 255.0f); //

    // ROCK DAMAGED COLOURS
    public static Color rockDamagedColour = new Color(181.0f / 255.0f, 151.0f / 255.0f, 83.0f / 255.0f); // SET NORMAL COLOUR
    public static Color rockDamagedColourRedSafe = new Color(181.0f / 255.0f, 151.0f / 255.0f, 83.0f / 255.0f);
    public static Color rockDamagedColourGreenSafe = new Color(132.0f / 255.0f, 132.0f / 255.0f, 132.0f / 255.0f);
    public static Color rockDamagedColourBlueSafe = new Color(132.0f / 255.0f, 132.0f / 255.0f, 132.0f / 255.0f); //

    // ROCK DAMAGED PARTICLE SYSTEM COLOURS
    public static Color rockDamagedPSColour = new Color(rockColour.r, rockColour.g, rockColour.b); // SET NORMAL COLOUR - COPIED FROM ABOVE
    public static Color rockDamagedPSColourRedSafe = new Color(rockColourRedSafe.r, rockColourRedSafe.g, rockColourRedSafe.b);
    public static Color rockDamagedPSColourGreenSafe = new Color(rockColourGreenSafe.r, rockColourGreenSafe.g, rockColourGreenSafe.b);
    public static Color rockDamagedPSColourBlueSafe = new Color(rockColourBlueSafe.r, rockColourBlueSafe.g, rockColourBlueSafe.b);

    // CRYSTAL COLOURS
    public static Color crystalColour = new Color(0.0f / 255.0f, 255.0f / 255.0f, 229.0f / 255.0f); // SET NORMAL COLOUR
    public static Color crystalColourRedSafe = new Color(0.0f / 255.0f, 255.0f / 255.0f, 229.0f / 255.0f);
    public static Color crystalColourGreenSafe = new Color(191.0f / 255.0f, 0.0f / 255.0f, 255.0f / 255.0f);
    public static Color crystalColourBlueSafe = new Color(191.0f / 255.0f, 0.0f / 255.0f, 255.0f / 255.0f); //

    // CRYSTAL DAMGED PARTICLE SYSTEM COLOURS
    public static Color crystalDamagedPSColour = new Color(crystalColour.r, crystalColour.g, crystalColour.b); // SET NORMAL COLOUR - COPIED FROM ABOVE
    public static Color crystalDamagedPSColourRedSafe = new Color(crystalColourRedSafe.r, crystalColourRedSafe.g, crystalColourRedSafe.b);
    public static Color crystalDamagedPSColourGreenSafe = new Color(crystalColourGreenSafe.r, crystalColourGreenSafe.g, crystalColourGreenSafe.b);
    public static Color crystalDamagedPSColourBlueSafe = new Color(crystalColourBlueSafe.r, crystalColourBlueSafe.g, crystalColourBlueSafe.b);

    // PICK UP COLOURS
    public static Color pickUpColour = new Color(255.0f / 255.0f, 215.0f / 255.0f, 0.0f / 255.0f); // SET NORMAL COLOUR
    public static Color pickUpColourRedSafe = new Color(255.0f / 255.0f, 215.0f / 255.0f, 0.0f / 255.0f);
    public static Color pickUpColourGreenSafe = new Color(218.0f / 255.0f, 165.0f / 255.0f, 32.0f / 255.0f);
    public static Color pickUpColourBlueSafe = new Color(218.0f / 255.0f, 165.0f / 255.0f, 32.0f / 255.0f); //

    // BASIC MONSTER COLOURS
    public static Color basicMonColour = new Color(226.0f / 255.0f, 0.0f / 255.0f, 0.0f / 255.0f); // SET NORMAL COLOUR
    public static Color basicMonColourRedSafe = new Color(226.0f / 255.0f, 0.0f / 255.0f, 0.0f / 255.0f);
    public static Color basicMonColourGreenSafe = new Color(87.0f / 255.0f, 155.0f / 255.0f, 0.0f / 255.0f);
    public static Color basicMonColourBlueSafe = new Color(87.0f / 255.0f, 155.0f / 255.0f, 0.0f / 255.0f); //

    // JUICY MONSTER COLOURS
    public static Color juicyMonColour = new Color(87.0f / 255.0f, 155.0f / 255.0f, 0.0f / 255.0f); // SET NORMAL COLOUR
    public static Color juicyMonColourRedSafe = new Color(87.0f / 255.0f, 155.0f / 255.0f, 0.0f / 255.0f);
    public static Color juicyMonColourGreenSafe = new Color(226.0f / 255.0f, 0.0f / 255.0f, 0.0f / 255.0f);
    public static Color juicyMonColourBlueSafe = new Color(226.0f / 255.0f, 0.0f / 255.0f, 0.0f / 255.0f); //

    // Chest and key colours - NORMAL VISION
    public static Color[] chestKeyColours = new Color[] { Color.red, Color.green, Color.blue, Color.yellow, Color.magenta, Color.cyan }; // SET NORMAL COLOUR
    public static Color[] chestKeyColoursRedSafe = new Color[] { Color.red, Color.green, Color.blue, Color.yellow, Color.magenta, Color.cyan }; //
    public static Color[] chestKeyColoursGreenSafe = new Color[] { Color.red, Color.green, Color.blue, Color.yellow, Color.magenta, Color.cyan }; //
    public static Color[] chestKeyColoursBlueSafe = new Color[] { Color.red, Color.green, Color.blue, Color.yellow, Color.magenta, Color.cyan }; //

    // UI COLOURS
    public static Color UITextColour = new Color(255.0f / 255.0f, 254.0f / 255.0f, 239.0f / 255.0f); // SET NORMAL COLOUR
    public static Color UITextColourRedSafe = new Color(255.0f / 255.0f, 254.0f / 255.0f, 239.0f / 255.0f);
    public static Color UITextColourGreenSafe = new Color(255.0f / 255.0f, 188.0f / 255.0f, 204.0f / 255.0f);
    public static Color UITextColourBlueSafe = new Color(255.0f / 255.0f, 188.0f / 255.0f, 204.0f / 255.0f); //

    // UI BACKGROUND COLOURS
    public static Color UIBackgroundColour = new Color(33.0f / 255.0f, 22.0f / 255.0f, 0.0f / 255.0f); // SET NORMAL COLOUR
    public static Color UIBackgroundColourRedSafe = new Color(33.0f / 255.0f, 22.0f / 255.0f, 0.0f / 255.0f);
    public static Color UIBackgroundColourGreenSafe = new Color(9.0f / 255.0f, 0.0f / 255.0f, 56.0f / 255.0f);
    public static Color UIBackgroundColourBlueSafe = new Color(9.0f / 255.0f, 0.0f / 255.0f, 56.0f / 255.0f); //

    // ROCK GRADIENTS
    public static Gradient rockDamagedColourGrad = new Gradient();
    public static Gradient rockDamagedColourGradRedSafe = new Gradient();
    public static Gradient rockDamagedColourGradGreenSafe = new Gradient();
    public static Gradient rockDamagedColourGradBlueSafe = new Gradient();

    // CRYSTAL GRADIENTS
    public static Gradient crystalDamagedColourGrad = new Gradient();
    public static Gradient crystalDamagedColourGradRedSafe = new Gradient();
    public static Gradient crystalDamagedColourGradGreenSafe = new Gradient();
    public static Gradient crystalDamagedColourGradBlueSafe = new Gradient();

    // Set particle system colour gradient
    public static void ColoursPSGradient()
    {
        // Normal
        rockDamagedColourGrad.SetKeys
        (
            new GradientColorKey[] { new GradientColorKey(rockDamagedColour, 0.0f), new GradientColorKey(rockDamagedColour, 1.0f) },
            new GradientAlphaKey[] { new GradientAlphaKey(1.0f, 0.0f), new GradientAlphaKey(0.0f, 1.0f) }
        );

        // Red safe
        rockDamagedColourGradRedSafe.SetKeys
        (
            new GradientColorKey[] { new GradientColorKey(rockDamagedPSColourRedSafe, 0.0f), new GradientColorKey(rockDamagedPSColourRedSafe, 1.0f) },
            new GradientAlphaKey[] { new GradientAlphaKey(1.0f, 0.0f), new GradientAlphaKey(0.0f, 1.0f) }
        );

        // Green safe
        rockDamagedColourGradGreenSafe.SetKeys
        (
            new GradientColorKey[] { new GradientColorKey(rockDamagedPSColourGreenSafe, 0.0f), new GradientColorKey(rockDamagedPSColourGreenSafe, 1.0f) },
            new GradientAlphaKey[] { new GradientAlphaKey(1.0f, 0.0f), new GradientAlphaKey(0.0f, 1.0f) }
        );

        // Blue safe
        rockDamagedColourGradBlueSafe.SetKeys
        (
            new GradientColorKey[] { new GradientColorKey(rockDamagedPSColourBlueSafe, 0.0f), new GradientColorKey(rockDamagedPSColourBlueSafe, 1.0f) },
            new GradientAlphaKey[] { new GradientAlphaKey(1.0f, 0.0f), new GradientAlphaKey(0.0f, 1.0f) }
        );

        // Normal
        crystalDamagedColourGrad.SetKeys
        (
            new GradientColorKey[] { new GradientColorKey(crystalColour, 0.0f), new GradientColorKey(crystalColour, 1.0f) },
            new GradientAlphaKey[] { new GradientAlphaKey(1.0f, 0.0f), new GradientAlphaKey(0.0f, 1.0f) }
        );

        // Red safe
        crystalDamagedColourGradRedSafe.SetKeys
        (
            new GradientColorKey[] { new GradientColorKey(crystalColourRedSafe, 0.0f), new GradientColorKey(crystalColourRedSafe, 1.0f) },
            new GradientAlphaKey[] { new GradientAlphaKey(1.0f, 0.0f), new GradientAlphaKey(0.0f, 1.0f) }
        );

        // green safe
        crystalDamagedColourGradGreenSafe.SetKeys
        (
            new GradientColorKey[] { new GradientColorKey(crystalColourGreenSafe, 0.0f), new GradientColorKey(crystalColourGreenSafe, 1.0f) },
            new GradientAlphaKey[] { new GradientAlphaKey(1.0f, 0.0f), new GradientAlphaKey(0.0f, 1.0f) }
        );

        // Blue safe
        crystalDamagedColourGradBlueSafe.SetKeys
        (
            new GradientColorKey[] { new GradientColorKey(crystalColourBlueSafe, 0.0f), new GradientColorKey(crystalColourBlueSafe, 1.0f) },
            new GradientAlphaKey[] { new GradientAlphaKey(1.0f, 0.0f), new GradientAlphaKey(0.0f, 1.0f) }
        );
    }
}