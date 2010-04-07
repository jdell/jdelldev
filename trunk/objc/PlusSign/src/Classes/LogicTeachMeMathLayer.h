//
//  LogicTeachMeLayer.h
//  plusSign
//
//  Created by Genki-Oki on 12/5/09.
//  Copyright 2009 Genki-Oki. All rights reserved.
//

#import <Foundation/Foundation.h>
#import "cocos2d.h"
#import "PSConstants.h"
#import "Button.h"
#import "PSBlock.h"
#import "TalkAction.h"
#import "TeachMeMenuScene.h"


@interface LogicTeachMeMathLayer : Layer {
	Sprite *gabrielSprite;
	Sprite *fingerSprite;
	Animation *gabrielTalking;
	Label *words;
	int currentStep;
	Sprite *wordBubble;
	PSBlock *board[3][3];
	bool disappeared;
	
	PSBlock *selectedPSBlock;
	PSBlock *operand1PSBlock;
	
	Button * nextButton;
	Button * menuButton;
	CGPoint positionNextButton;
	
	Sprite *crossSprite;
	Sprite *xSprite;
	int frameCount;
	//int moveCycleRatio;
	
	CGPoint pointTouchedD;
	bool touched;
}
- (void) updateBoard:(ccTime)dt;
- (void)nextStep: (id)sender;
- (void)goToStep: (int)step;
- (void)goToMainMenu:(id)sender;
- (CGPoint)positionFinger:(int)step;
- (void) moveBlocksDown;
- (void) operate:(PSBlock *)mainSprite: (PSBlock *)operand1: (PSBlock *)operand2;

@end
