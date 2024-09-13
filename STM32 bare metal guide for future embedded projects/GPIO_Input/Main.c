#include "Utility.h"
#include <stdint.h>
#include <stdbool.h>


int pinPB7Counter = 0x00; 

void executeWhenPinHigh(void)
{
	pinPB7Counter++; 
}

int main()
{
	bool volatile pinPB7Status ; 
	
	
	GPIOGeneralRegister* GPIO_B; 
	
	REG32(RCC_BASE_ADDRESS + RCC_AHB1_OFFSET) |= BIT_1; 
	
	GPIO_B  = (GPIOGeneralRegister*)(GPIOB_BASE_ADDRESS); 
	
	GPIO_B->MODER &= ~(uint32_t)(BIT_15 | BIT_14); 
	
	GPIO_B->OTYPER &= ~(uint32_t)(BIT_7);
	
	GPIO_B->OSPEEDR |= BIT_14;

	GPIO_B->PUPDR |= BIT_15; 
	
	while(1)
	{
	pinPB7Status = ((GPIO_B->IDR) & BIT_7); 
		if (pinPB7Status)
		{
			executeWhenPinHigh();
		}
	}
		
	return 0 ; 
}