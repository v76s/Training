#include <stdint.h>
#include <stdlib.h>
#include "Utility.h"

// Function to create a simple blocking delay (not precise)
void Delay_ms(uint32_t ms) {
    volatile uint32_t Counter = 0x00;
    for (uint32_t i = 0; i < ms * 1000; i++) {
        Counter++;
    }
}

int main()
{
	GPIOGeneralRegister* GPIOD; 
	
	GPIOD = (GPIOGeneralRegister*)(GPIOD_BASE_ADDRESS);
	
	REG32(RCC_BASE_ADDRESS + RCC_AHB1_OFFSET) |=  BIT_3;
	
	GPIOD->MODER |= BIT_24 ;
	GPIOD->OTYPER &= ~(uint32_t) BIT_12;
	GPIOD->OSPEEDR &= ~(uint32_t)(BIT_24 | BIT_25);
	GPIOD->PUPDR |= BIT_26 ; 


while(1)
	{
			GPIOD->BSRR |= BIT_12;
			Delay_ms(100) ;
	    GPIOD->BSRR |= BIT_28; 
 
		
		  GPIOD->BSRR |= BIT_13;
			Delay_ms(100); 
		  GPIOD->BSRR |= BIT_29 ; 
	}	
}