#ifndef REGISTER_H
#define REGISTER_H

#include <stdint.h>

#define RCC_BASE_ADDRESS        0x40023800     // RCC Base address
#define RCC_AHB1_OFFSET         0x30

//GPIOA	0x40020000
//GPIOB	0x40020400
//GPIOC	0x40020800
//GPIOD	0x40020C00
//GPIOE	0x40021000
//GPIOH	0x40021C00

#define SYSCFG_ADDRESS 			0x40013800	// The system configuration register address. 
#define EXTI_ADDRESS				0x40013C00  

#define GPIOA_BASE_ADDRESS 	0x40020000	// GPIO-A Base Address
#define GPIOB_BASE_ADDRESS 	0x40020400	// GPIO-B Base Address
#define GPIOC_BASE_ADDRESS 	0x40020800	// GPIO-C Base Address
#define GPIOD_BASE_ADDRESS 	0x40020C00	// GPIO-D Base Address
#define GPIOE_BASE_ADDRESS      0x40021000     	// GPIO-E Base address

#define GPIOD_MODER_OFFSET      0x00
#define GPIOD_OTYPER_OFFSET			0x04
#define GPIOD_OSPEEDR_OFFSET 		0x08
#define GPIOD_PUPDR_OFFSET			0x0C
#define GPIOD_BSRR_OFFSET       0x18

#define BIT_0     (1 << 0)
#define BIT_1     (1 << 1)
#define BIT_2     (1 << 2)
#define BIT_3     (1 << 3)
#define BIT_4     (1 << 4)
#define BIT_5     (1 << 5)
#define BIT_6     (1 << 6)
#define BIT_7     (1 << 7)
#define BIT_8     (1 << 8)
#define BIT_9     (1 << 9)
#define BIT_10    (1 << 10)
#define BIT_11    (1 << 11)
#define BIT_12    (1 << 12)
#define BIT_13    (1 << 13)
#define BIT_14    (1 << 14)
#define BIT_15    (1 << 15)
#define BIT_16    (1 << 16)
#define BIT_17    (1 << 17)
#define BIT_18    (1 << 18)
#define BIT_19    (1 << 19)
#define BIT_20    (1 << 20)
#define BIT_21    (1 << 21)
#define BIT_22    (1 << 22)
#define BIT_23    (1 << 23)
#define BIT_24    (1 << 24)
#define BIT_25    (1 << 25)
#define BIT_26    (1 << 26)
#define BIT_27    (1 << 27)
#define BIT_28    (1 << 28)
#define BIT_29    (1 << 29)
#define BIT_30    (1 << 30)
#define BIT_31    (1 << 31)

#define REG32(x)  *((uint32_t volatile*)(x))	

typedef struct
{
   uint32_t MODER;
   uint32_t OTYPER;
   uint32_t OSPEEDR; 
   uint32_t PUPDR ; 
   uint32_t IDR ; 
   uint32_t ODR ; 
   uint32_t BSRR;
   uint32_t LCKR; 
   uint32_t AFRL; 
   uint32_t AFRH; 
} GPIOGeneralRegister;


typedef struct
{
   uint32_t MEMRMP;
   uint32_t PMC;
   uint32_t EXTICR1; 
   uint32_t EXTICR2;
   uint32_t EXTICR3; 
   uint32_t EXTICR4; 
   uint32_t CMPCR; 
} Syscfg ; 


typedef struct
{
	uint32_t IMR ; 
	uint32_t EMR; 
	uint32_t RTSR; 
	uint32_t FTSR; 
	uint32_t SWIER ; 
	uint32_t PR ; 	
}Exti; 


#endif