#include <stdio.h>
#include <stdlib.h>
#include "cat.h"
#include "dog.h"
#include "canary.h"

int main(int argc, char const *argv[])
{
	Cat* hopkins = CAT_create("Hopkins");
	Dog* alfred = DOG_create("Alfred");
	Canary* tweety = CANARY_create("Tweety");
	
	// Suscripción al evento SPEAK
	alfred->smell(alfred, hopkins);
	// Publicación del evento 
	tweety->see(tweety,hopkins);


	hopkins->destroy(hopkins);
	alfred->destroy(alfred);
	tweety->destroy(tweety);
	return EXIT_SUCCESS;
}

