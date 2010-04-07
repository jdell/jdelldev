//
//  GameLayer.h
//  plusSign
//
//  Created by Genki-Oki on 8/13/09.
//  Copyright 2009 Genki-Oki. All rights reserved.
//

#import <Foundation/Foundation.h>
#import "cocos2d.h"
#import "PSBlock.h"
#import "PSConstants.h"
#import "GameState.h"
#import "SimpleAudioEngine.h"
#import "EndGameScene.h"
@class ControlGameLayer;

#define kLastColumn PSCONFIG_GAMEPLAY_BLOCKS_COLS
#define kLastRow PSCONFIG_GAMEPLAY_BLOCKS_ROWS

@interface GameLayer : Layer {
	Sprite * readyToGO;
	Sprite * gabrielTalking;
	Animation *talking;
	
	ParallaxNode *scroller;
	CGPoint positionBegan;
	CGPoint positionMoved;
	bool moved;
	int scrollerLastY;
	bool fallen;
	
	PSBlock *board[kLastColumn +1][kLastRow + 1];
	int frameCount;
	int pointsToAdd;
	
	CGPoint pointTouchedD;
	bool touched;
	PSBlock *selectedPSBlock;
	PSBlock *operand1PSBlock;
	bool disappeared;
	ControlGameLayer *controlLayer;
	int counterTime;
	int counterScore;
	
	int speedEffect;
	
	bool blowingUp;
}

- (void) updateBoard:(ccTime)dt;
- (void) moveBlocksDown;
- (void) operate:(PSBlock *)mainSprite: (PSBlock *)operand1: (PSBlock *)operand2;

@end
