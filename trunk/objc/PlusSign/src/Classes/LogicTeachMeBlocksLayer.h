//
//  LogicTeachMeBlocksLayer.h
//  plusSign
//
//  Created by Genki-Oki on 12/6/09.
//  Copyright 2009 Genki-Oki. All rights reserved.
//

#import <Foundation/Foundation.h>
#import "cocos2d.h"
#import "PSConstants.h"
#import "Button.h"
#import "PSBlock.h"
#import "TalkAction.h"
#import "TeachMeMenuScene.h"


@interface LogicTeachMeBlocksLayer : Layer {
	CGPoint positionNextButton;
	CGPoint positionGabriel;
	CGPoint positionWordBubble ;
	CGPoint positionWords ;
	
	Sprite *gabrielSprite;
	Sprite *fingerSprite;
	Animation *gabrielTalking;
	Label *words;
	int currentStep;
	Sprite *wordBubble;
	PSBlock *board[3][3];
	bool disappeared;
	Button * nextButton;
	Button * menuButton;
	
	PSBlock *selectedPSBlock;
	PSBlock *operand1PSBlock;
	
	Sprite *crossSprite;
	Sprite *xSprite;
	int frameCount;
	//int moveCycleRatio;
	
	CGPoint pointTouchedD;
	bool touched;
}
- (void)nextStep: (id)sender;
- (void)goToStep: (int)step;
- (void)goToMainMenu:(id)sender;
- (CGPoint)positionFinger:(int)step;

@end
