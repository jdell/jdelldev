//
//  LogicTeachMeBasicsLayer.h
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

typedef enum BasicTestTypes{
	TESTPLUS = 0,
	TESTMINUS = 1,
	TESTTIMES = 2,
	TESTDIVISION = 3
} BasicTestType;

@interface LogicTeachMeBasicsLayer : Layer {
	PSBlock *board[3];
	Sprite *gabrielSprite;
	Sprite *fingerSprite;
	Animation *gabrielTalking;
	Label *words;
	int currentStep;
	Sprite *wordBubble;
	Button * nextButton;
	Button * menuButton;
	
	BasicTestType currentTest;
	
	CGPoint positionNextButton;
	CGPoint positionGabriel;
	CGPoint positionWordBubble;
	CGPoint positionWords;
}
- (void)nextStep: (id)sender;
- (void)goToStep: (int)step;
- (void)goToMainMenu:(id)sender;
- (void)doTest:(BasicTestType)type;
- (void)wrongSolution;
- (void)rightSolution;

@end
