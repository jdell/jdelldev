//
//  GameLayer.m
//  plusSign
//
//  Created by Genki-Oki on 8/13/09.
//  Copyright 2009 Genki-Oki. All rights reserved.
//

#import "GameLayer.h"
#import "RotateAround.h"
#import "ControlGameLayer.h"

@interface GameLayer(private)

- (void) startGame;
//- (void) clearBoard;
- (void) gameOver;
- (void) loadGame;
- (void) resetBoard;
- (void) prepareGame;

- (void) processTabs;
- (void) computeScore;
- (void) disappearBlocks;

- (void) findBlockGrouping;
- (void) updateInfoDisplays;
- (BOOL) hasMovements;
- (void) checkForBlockGroupings:(PSBlock *) psblock;

- (void) setOperable:(int) x:(int) y;

- (void) moveBlockUp:(PSBlock *)psblock;
- (void) moveBlockRight:(PSBlock *)psblock;
- (void) moveBlockDown:(PSBlock *)psblock;
- (void) moveBlockUp:(PSBlock *)psblock;

@end

@implementation GameLayer

- (void) moveBlockUp:(PSBlock *)psblock {
	board[psblock.boardX][psblock.boardY] = nil;
	board[psblock.boardX][psblock.boardY + 1] = psblock;
	psblock.moveUp;
}

- (void) moveBlockDown:(PSBlock *)psblock {
	
	board[psblock.boardX][psblock.boardY] = nil;
	board[psblock.boardX][psblock.boardY - 1] = psblock;
	
	psblock.boardY -= 1;
	
	CGPoint position = COMPUTE_X_Y(psblock.boardX, psblock.boardY);
	
	id rotateAction = [RotateBy actionWithDuration:0.01 angle:10];
	id action = [Spawn actions:
				 rotateAction,
				 [ReverseTime actionWithAction:rotateAction],
				 [MoveTo actionWithDuration:0.001 position:position],
				 nil];
	
	[psblock runAction:action];
	
	[scroller removeChild:psblock cleanup:NO];
	[scroller addChild:psblock z:2 parallaxRatio:ccp(1.0f,1.0f) positionOffset:position];
	
	
	//psblock.moveDown;	
}

- (void) moveBlockLeft:(PSBlock *)psblock {
	board[psblock.boardX][psblock.boardY] = nil;
	board[psblock.boardX-1][psblock.boardY] = psblock;
	psblock.moveLeft;
}

- (void) moveBlockRigh:(PSBlock *)psblock {
	board[psblock.boardX][psblock.boardY] = nil;
	board[psblock.boardX+1][psblock.boardY] = psblock;
	psblock.moveRight;
}

- (void) gameOver {
	// Stop the game loop ...
	[self unschedule:@selector(updateBoard:)];
	
	counterScore += PSCONFIG_GAMEPLAY_SCORE_VALUE_BONUS;
	if (currentState.signPlus) counterScore += PSCONFIG_GAMEPLAY_SCORE_VALUE_SIGN;
	if (currentState.signMinus) counterScore += PSCONFIG_GAMEPLAY_SCORE_VALUE_SIGN;	
	if (currentState.signTimes) counterScore += PSCONFIG_GAMEPLAY_SCORE_VALUE_SIGN;
	if (currentState.signDivision) counterScore += PSCONFIG_GAMEPLAY_SCORE_VALUE_SIGN;	
	
	currentState.time = currentState.time * 60 - counterTime;
	currentState.score = counterScore;
	
	[[Director sharedDirector] replaceScene:[MoveInRTransition transitionWithDuration:0.2 scene:[EndGameScene node]]];
}

- (void) loadGame
{
	// Seed random number generator.
	struct timeval tv;
	gettimeofday( &tv, 0 );
	srandom( tv.tv_usec + tv.tv_sec );
	
	
	for (int x=0; x<=kLastColumn; x++) 
	{
		for (int y=0; y<=kLastRow; y++) 
		{
			PSBlock *block = [[PSBlock newPSBlock] retain];
			
			block.boardX = x;
			block.boardY = y;
			CGPoint position =  COMPUTE_X_Y(x, y);
			block.position = position;
			board[x][y] = block;
			[scroller addChild:block z:2 parallaxRatio:ccp(1.0f,1.0f) positionOffset:block.position];
			
			[block runAction:[FadeIn actionWithDuration:1]];
		//	[spriteWhite runAction:  [Sequence actions:[FadeTo actionWithDuration:0.5 opacity:0],[DelayTime actionWithDuration:0.5], nil]];
		}
	}
}

- (void) setStartGame
{	
	for (int x=0; x<=kLastColumn; x++) 
	{
		for (int y=0; y<=kLastRow; y++) 
		{
			PSBlock *block = board[x][y];
			if (block!=nil)
				[block SetActive:YES];
		}
	}
}

- (void) resetBoard
{
	selectedPSBlock = nil;
	operand1PSBlock = nil;
	for (int x=0; x<=kLastColumn; x++) 
	{
		for (int y=0; y<=kLastRow; y++) 
		{			
			PSBlock *block = board[x][y];
			if (block!=nil)
			{
				//block.position = COMPUTE_X_Y(x, y);
				[block SetMarkedAs:NORMAL];
			}
		}
	}
}

- (void) randomizeBoard:(PSBlock*)block
{
	if (block==nil) return;
	
	selectedPSBlock = nil;
	operand1PSBlock = nil;
	
	for (int x=0; x<=kLastColumn; x++) 
	{
		for (int y=0; y<=kLastRow; y++) 
		{			
			PSBlock *tmpBlock = board[x][y];
			if (tmpBlock!=nil)
			{
				if ((block.boardX == x) && (block.boardY == y)) continue;
				
				
				[scroller removeChild:tmpBlock cleanup:YES];
				tmpBlock = nil;
				board[x][y] = nil;
				
				//TODO: Hay un bug con la estrella
				tmpBlock = [[PSBlock newPSBlock] retain];			
				tmpBlock.boardX = x;
				tmpBlock.boardY = y;
				CGPoint position =  COMPUTE_X_Y(x, y);
				//position.y -= scroller.position.y;
				tmpBlock.position = position;	
				//position.y += scroller.position.y;
				board[x][y] = tmpBlock;
				[scroller addChild:tmpBlock z:2 parallaxRatio:ccp(1.0f,1.0f) positionOffset:position];
			}
		}
	}
	
	id actionMove = [MoveTo actionWithDuration:0.2 position:ccp(scroller.position.x, scroller.position.y-2)];//BLOCK_HEIGHT/2)];
	[scroller runAction:[EaseElasticInOut actionWithAction: [Sequence actions:
						 actionMove,
						 [ReverseTime actionWithAction:actionMove],
						 nil
															 ] period:0.4]
	 ];
	
	
	//[scroller runAction:[EaseElasticInOut actionWithDuration:0.3]];
}

- (CGPoint) getMaxBlock
{
	CGPoint minBlock = ccp(kLastColumn+1, kLastRow+1);
	CGPoint maxBlock = ccp(-1,-1);
	
	for (int y=0; y<=kLastRow; y++) 
	{
		for (int x=0; x<=kLastColumn; x++) 
		{	
			PSBlock *tmpBlock = board[x][y];
			if (tmpBlock!=nil)
			{			
				if ((kLastRow==y) || ( kLastRow > y && (nil == board[x][y + 1]) ) )
				{
					if (y<minBlock.y) 
					{
						minBlock.y = y;
						minBlock.x = x;
					}
					if ((y>maxBlock.y) || ((y==maxBlock.y) && (abs(x-minBlock.x)<abs(maxBlock.x-minBlock.x)) ))
					{
						maxBlock.y = y;
						maxBlock.x = x;
					}
				}
			}
			else
			{
				if (y==0)
				{
					minBlock.y = -1;
					minBlock.x = x;
				}
			}
		}
	}
	return maxBlock;

}

- (void) fallenBlocks
{
	//find min + max
	CGPoint minBlock = ccp(kLastColumn+1, kLastRow+1);
	CGPoint maxBlock = ccp(-1,-1);
	
		for (int y=0; y<=kLastRow; y++) 
		{
			for (int x=0; x<=kLastColumn; x++) 
		{	
			PSBlock *tmpBlock = board[x][y];
			if (tmpBlock!=nil)
			{			
			if ((kLastRow==y) || ( kLastRow > y && (nil == board[x][y + 1]) ) )
				{
					if (y<minBlock.y) 
					{
						minBlock.y = y;
						minBlock.x = x;
					}
					if ((y>maxBlock.y) || ((y==maxBlock.y) && (abs(x-minBlock.x)<abs(maxBlock.x-minBlock.x)) ))
					{
						maxBlock.y = y;
						maxBlock.x = x;
					}
				}
			}
			else
			{
				if (y==0)
				{
					minBlock.y = -1;
					minBlock.x = x;
				}
			}
		}
	}
	//boardYmax - boardYmin >= 2 --> fall!
	if (maxBlock.y-minBlock.y>=2)
	{
		PSBlock *block = board[(int)maxBlock.x][(int)maxBlock.y];
		
		board[block.boardX][block.boardY] = nil;
		block.boardY = maxBlock.y;
		block.boardX = minBlock.x;
		block.stuck = NO;	
		board[block.boardX][block.boardY] = block;
		
		CGPoint pointColumn = COMPUTE_X_Y(block.boardX, block.boardY);
		id rotateAction = [RotateBy actionWithDuration:0.01 angle:10];
		id action = [Spawn actions:
					 rotateAction,
					 [ReverseTime actionWithAction:rotateAction],
					 [MoveTo actionWithDuration:0.001 position:pointColumn],
					 nil];
		
		[block runAction:action];
		
		[scroller removeChild:block cleanup:NO];
		[scroller addChild:block z:2 parallaxRatio:ccp(1.0f,1.0f) positionOffset:pointColumn];
		
		
		fallen = YES;
		[self moveBlocksDown];
	}
}

- (id) init{
	self = [super init];
	if (self != nil)
	{ 
		[self setIsTouchEnabled:YES];
		touched = NO;
		scroller = [ParallaxNode node];
		[scroller setPosition:ccp(0,0)];
		[self addChild:scroller];
				
		
		controlLayer = [ControlGameLayer node];
		[self addChild:controlLayer z:3];

		gabrielTalking = [Sprite spriteWithFile:CONSTANT_ANIMATION_GABIHEAD_1_SMALL];
		[gabrielTalking setPosition:ccp(160, 240-80)];
		[self addChild:gabrielTalking z:9];	
		
		talking = [[Animation alloc] initWithName:@"gabrielTalking" delay:0.6];
		[talking addFrameWithFilename:CONSTANT_ANIMATION_GABIHEAD_1_SMALL];
		[talking addFrameWithFilename:CONSTANT_ANIMATION_GABIHEAD_2_SMALL];
		//[talking addFrameWithFilename:CONSTANT_ANIMATION_GABIHEAD_3_SMALL];
		[gabrielTalking addAnimation:talking];
		
		 /*
		 Animation *intro = [[Animation alloc] initWithName:@"intro" delay:2];
		 [intro addFrameWithFilename:CONSTANT_WORDBUBBLES_READY];
		 [intro addFrameWithFilename:CONSTANT_WORDBUBBLES_GO];
		 [readyToGO addAnimation:intro];
		
		//two actions: sprite+scale+sound+talking+fadeOut
		
		[readyToGO runAction:[Sequence actions:
							  [Spawn actions:
							   [ScaleTo actionWithDuration:0.5 scale:1],
							   [Animate actionWithAnimation:intro],
							   [CallFunc actionWithTarget:self selector:@selector(doTalk)],
							   [CallFunc actionWithTarget:self selector:@selector(doSound)],
							   nil
							   ],
							  [Spawn actions:
							   [FadeOut actionWithDuration:1],
							   [CallFunc actionWithTarget:self selector:@selector(doFadeTo)],
							   nil
							   ],
							  nil
							  ]
							];
		
		
		
		[self schedule:@selector(onEnd:) interval:2];
		*/
		[self runAction:[Sequence actions:
						 [CallFunc actionWithTarget:self selector:@selector(doIntroReady)],
						 [DelayTime actionWithDuration:1],
						 //[CallFunc actionWithTarget:self selector:@selector(doLoadGame)],	
						 //[DelayTime actionWithDuration:1],
						 [CallFunc actionWithTarget:self selector:@selector(doIntroGO)],	
						 nil]];
		
		
		// clear the board
		memset(board, 0, sizeof(board));
		[self loadGame];
		
		[self schedule:@selector(onEnd:) interval:2];
	}
	return self;
}

- (void) doIntroReady
{
	
	// ***** FadeOut Background *****
	//Sprite * spriteWhite = [Sprite spriteWithFile:CONSTANT_WORDBUBBLES_NEWWORDBUBBLES_WHITEREADY];
	//[spriteWhite setPosition:ccp(160, 240)];
	//[spriteWhite setScale:1.5f];
	//[self addChild:spriteWhite z:0];	
	
	Sprite * sprite = [Sprite spriteWithFile:CONSTANT_WORDBUBBLES_READY];
	[sprite setPosition:ccp(160, 240)];
	[sprite setScale:1.5f];
	[self addChild:sprite z:1];
	
	[sprite runAction:[Sequence actions:
						[Spawn actions:
						 [ScaleTo actionWithDuration:0.5 scale:1],
						 [CallFunc actionWithTarget:self selector:@selector(doSoundReady)],
						 [CallFunc actionWithTarget:self selector:@selector(doTalk)],
						 [FadeIn actionWithDuration:1],
					   nil
					   ],
					   [FadeOut actionWithDuration:0.1],
					   //[CallFunc actionWithTarget:self selector:@selector(doFadeTo)],
	 nil
	 ]];
	//[spriteWhite runAction:  [Sequence actions:[FadeTo actionWithDuration:0.5 opacity:0],[DelayTime actionWithDuration:0.5], nil]];
}
- (void) doLoadGame
{
	// clear the board
	memset(board, 0, sizeof(board));
	[self loadGame];
}
- (void) doSoundReady
{
	[[SimpleAudioEngine sharedEngine] playEffect:CONSTANT_VOICE_READY];
}

- (void) doSoundGO
{
	[[SimpleAudioEngine sharedEngine] playEffect:CONSTANT_VOICE_GO];
}
	- (void) doIntroGO
	{
		// ***** FadeOut Background *****
		//Sprite * spriteWhite = [Sprite spriteWithFile:CONSTANT_WORDBUBBLES_NEWWORDBUBBLES_WHITEGO];
		//[spriteWhite setPosition:ccp(160, 240)];
		//[spriteWhite setScale:1.5f];
		//[self addChild:spriteWhite z:0];	
	
		Sprite * sprite = [Sprite spriteWithFile:CONSTANT_WORDBUBBLES_GO];
		[sprite setPosition:ccp(160, 240)];
		[sprite setScale:1.5f];
		[self addChild:sprite z:1];
		
		[sprite runAction:[Sequence actions:
						   [Spawn actions:
							[ScaleTo actionWithDuration:0.5 scale:1],
							[CallFunc actionWithTarget:self selector:@selector(doSoundGO)],
							[CallFunc actionWithTarget:self selector:@selector(doTalk)],
							[FadeIn actionWithDuration:1],
							nil
							],
						   [FadeOut actionWithDuration:0.1],
						   [CallFunc actionWithTarget:self selector:@selector(doFadeTo)],
						   nil
						   ]];

		//[spriteWhite runAction:  [Sequence actions:[FadeTo actionWithDuration:0.5 opacity:0],[DelayTime actionWithDuration:0.5], nil]];

	}

- (void) doTalk
{
	
	[gabrielTalking runAction:[Repeat actionWithAction:[Animate actionWithAnimation:talking] times:1]];
	
}
- (void) doFadeTo
{
	
	[gabrielTalking runAction:[FadeOut actionWithDuration:0.66]];
	
}

- (void) doSound
{
	//DEPRECATE: [[SimpleAudioEngine sharedEngine] playEffect:CONSTANT_VOICE_READY];
	//DEPRECATE: [[SimpleAudioEngine sharedEngine] playEffect:CONSTANT_VOICE_GO];
}

- (void)onEnd:(ccTime)dt
{
	
	[self startGame];
	
	
	[self unschedule:@selector(onEnd:)];
}

- (void) startGame {
	
	//[self loadGame];
	[self setStartGame];
	blowingUp = NO;
	disappeared = NO;
	counterScore = 0;
	frameCount = 0;
	speedEffect = 60;
	//moveCycleRatio = 15; // Drop puyos every 3/4 second 
	counterTime = 60 * currentState.time; //t min
	
	// Execute updateBoard 60 times per second.
	[self schedule:@selector(updateBoard:) interval: 1.0 / 60.0];
	//[self schedule:@selector(updateBoard:) interval: 1.0];
 
}


- (BOOL) isTicTacToe:(PSBlock *)mainSprite: (PSBlock *)operand1: (PSBlock *)operand2
{
	BOOL res = NO;
	
	float xDifference = operand1.boardX + operand2.boardX;
	float yDifference = operand1.boardY + operand2.boardY;
	float xMain = (float)mainSprite.boardX;
	float yMain = (float)mainSprite.boardY;
	
	res = (xDifference/2 == xMain) && (yDifference/2 == yMain);

	return res;
}

- (void) operate:(PSBlock *)mainSprite: (PSBlock *)operand1: (PSBlock *)operand2
{
	/*
	int x = mainSprite.boardX + (mainSprite.boardX - operand1.boardX);
	int y = mainSprite.boardY + (mainSprite.boardY - operand1.boardY);
	
	if ((x<=kLastColumn) && (x>=0) && (y<=kLastRow) && (y>=0))
	{
		PSBlock *operand2 = board[x][y];*/
		if (operand2!=nil)
		{
			int mainValue = mainSprite.value;
			int operand1Value = operand1.value;
			int operand2Value = operand2.value;
			
			bool ticTacToe = [self isTicTacToe:mainSprite:operand1 :operand2];

			bool result = (mainValue == (int)LEAF);
			if (currentState.signPlus) result  = result || (mainValue == operand1Value + operand2Value);
			if (currentState.signMinus) result = result || (mainValue == abs(operand1Value - operand2Value)) ;
			if (currentState.signTimes) result = result || (mainValue == operand1Value * operand2Value);
			if (currentState.signDivision) result = result || (mainValue == operand1Value / operand2Value) || (mainValue == operand2Value / operand1Value);
			
			if (
				(ticTacToe) &&
				 (result)
				)
			{
				[operand1 setDisappearing:YES] ;
				[operand2 setDisappearing:YES] ;
				[mainSprite setDisappearing:YES] ;
				pointsToAdd = PSCONFIG_GAMEPLAY_SCORE_VALUE_NORMALBLOCK;
			}
			else
			{
				[operand2 SetMarkedAs:OPERATED];
			}
		}
		else
		{
			[self resetBoard];
		}
	//}
}


- (BOOL)ccTouchesEnded:(NSSet *)touches withEvent:(UIEvent *)event 
{
	UITouch *touch = [touches anyObject];
	CGPoint point = [touch locationInView: [touch view]];
	point.y = 480 - (point.y + scroller.position.y);
	
	//Buscar el sprite tocado
	if (!moved)
	{
		touched = YES;
		pointTouchedD =  DECOMPUTE_X_Y(point.x, point.y);
	}
	else
	{
		
		int positionY =  scrollerLastY + ceil(((double)positionMoved.y - (double)positionBegan.y)/BLOCK_HEIGHT)*BLOCK_HEIGHT;
		if (positionY>0) positionY = 0;
		CGPoint locationMaxBlock = [self getMaxBlock];
		int currentLastRow = locationMaxBlock.y;
		if ((positionY<0) && (abs(positionY)>BLOCK_HEIGHT*(currentLastRow - 6))) positionY = -BLOCK_HEIGHT*(currentLastRow - 6);
		//if ((positionY<0) && (abs(positionY)>BLOCK_HEIGHT*(kLastRow - 6))) positionY = -BLOCK_HEIGHT*(kLastRow - 6); //5
		if (positionY>0) positionY = 0;
		[scroller runAction:[MoveTo actionWithDuration:0.1 position:ccp(scroller.position.x, positionY)]];
		
		scrollerLastY = scroller.position.y;
		moved = NO;
	}
	
  	return kEventHandled;
}
- (BOOL)ccTouchesBegan:(NSSet *)touches withEvent:(UIEvent *)event
{
	UITouch *touch = [touches anyObject];	
	CGPoint point = [touch locationInView: [touch view]];
	point.y = 480 - point.y;
	
	moved = NO;
	scrollerLastY = scroller.position.y;
	
	positionBegan = point;
		
  	return kEventHandled;
}
- (BOOL)ccTouchesMoved:(NSSet *)touches withEvent:(UIEvent *)event 
{
	UITouch *touch = [touches anyObject];
	CGPoint point = [touch locationInView: [touch view]];
	point.y = 480 - point.y;
	
	moved = YES;
	
	positionMoved = point;
	
	int positionY =  scrollerLastY + (positionMoved.y - positionBegan.y);
	if (positionY>BLOCK_HEIGHT) positionY = BLOCK_HEIGHT;
	CGPoint locationMaxBlock = [self getMaxBlock];
	int currentLastRow = locationMaxBlock.y;
	if ((positionY<0) && (abs(positionY)>BLOCK_HEIGHT*(currentLastRow - 6))) positionY = -BLOCK_HEIGHT*(currentLastRow - 6);
	if (positionY>BLOCK_HEIGHT) positionY = BLOCK_HEIGHT;
	[scroller runAction:[MoveTo actionWithDuration:0.1 position:ccp(scroller.position.x, positionY)]];
	
  	return kEventHandled;
}
- (void) updateBoard:(ccTime)dt
{
	frameCount++;
	[self processTabs];
	[self disappearBlocks];
	
	if (frameCount % PSCONFIG_GAMEPLAY_MOVECYCLERATIO == 0)
	{
		[self moveBlocksDown];
		[self findBlockGrouping];
		[self computeScore];
		[self updateInfoDisplays];
	}
	
}

- (void) setOperable:(int) x:(int) y
{
	if ((x<=kLastColumn) && (x>=0) && (y<=kLastRow) && (y>=0))
	{
		PSBlock *block = board[x][y];
		[block SetMarkedAs:OPERATED];
	}
}

- (void) processTabs
{
	//Procesa el toque
	//si se cumple el tic tac toe
	if (!touched) return;
	
	PSBlock *block = board[(int)pointTouchedD.x][ (int)pointTouchedD.y];
	if (block!=nil)
	{
		switch(block.markedAs)
		{
			case NORMAL:
			{
				[self resetBoard];
				[block SetMarkedAs:SELECTED];
				selectedPSBlock = block;
				
				if ((block.value == (int)STAR) || (block.value == (int)GREY)) break;
				
				[self setOperable:block.boardX-1 :block.boardY-1];
				[self setOperable:block.boardX-1 :block.boardY+0];
				[self setOperable:block.boardX-1 :block.boardY+1];
				
				[self setOperable:block.boardX+0 :block.boardY-1];
				//[self setOperable:block.boardX+0 :block.boardY+0];
				[self setOperable:block.boardX+0 :block.boardY+1];
				
				[self setOperable:block.boardX+1 :block.boardY-1];
				[self setOperable:block.boardX+1 :block.boardY+0];
				[self setOperable:block.boardX+1 :block.boardY+1];		
				
				break;
			}
			case SELECTED:
			{
				PSBlockValue value = block.value;
				switch (value) {
					case LEAF:
						[block SetMarkedAs:NORMAL];
						[self resetBoard];
						break;
					case STAR:
						[self randomizeBoard:block];
						[block setDisappearing:YES] ;
						pointsToAdd = PSCONFIG_GAMEPLAY_SCORE_VALUE_STARBLOCK;
						break;
					case GREY:
						
						break;
					default:
						[block SetMarkedAs:NORMAL];
						[self resetBoard];
						break;
				}
				
				break;
			}
			case OPERATED:
				if (operand1PSBlock == nil)
				{
					operand1PSBlock = block;
					[block SetMarkedAs:CLICKED];
					
					PSBlockValue value = selectedPSBlock.value;
					if (value == LEAF)
					{
						[operand1PSBlock setDisappearing:YES] ;
						[selectedPSBlock setDisappearing:YES] ;
						pointsToAdd = PSCONFIG_GAMEPLAY_SCORE_VALUE_LEAFBLOCK;
					}
				}
				else
				{
					[self operate:selectedPSBlock: operand1PSBlock :block];
				}
				break;
			case CLICKED:
				if (selectedPSBlock !=nil)
				{
					[block SetMarkedAs:OPERATED];
					operand1PSBlock = nil;
				}
				break;
			case BLAST1:
				break;
			case BLAST2:
				break;
			default:
				break;
		}
	}
	touched = NO;
}
- (void) findBlockGrouping
{
	//Procesa el toque
	//si se cumple el tic tac toe
}

- (PSBlock *)getBlock:(int) x:(int) y
{
	if ((x<=kLastColumn) && (x>=0) && (y<=kLastRow) && (y>=0))
	{
		PSBlock *block = board[x][y];
		return block;
	}
	return nil;
}

- (BOOL) canOperate:(PSBlock *)mainBlock operand1:(PSBlock *)operand1block operand2:(PSBlock *)operand2block
{
	 float mainValue = mainBlock.value;
	 
	 
	 bool result = (mainValue == (int)LEAF) && ((operand1block!=nil) || (operand2block!=nil));
	if ((!result) && (operand1block!=nil) && (operand2block!=nil) && (![mainBlock isSpecialBlock] && ![operand1block isSpecialBlock] && ![operand2block isSpecialBlock]))
	{
		float operand1Value = operand1block.value;
		float operand2Value = operand2block.value;
		bool ticTacToe = [self isTicTacToe:mainBlock:operand1block :operand2block];
		
		if ((!result) && (currentState.signPlus)) result  = result || (mainValue == operand1Value + operand2Value);
		if ((!result) && (currentState.signMinus)) result = result || (mainValue == abs(operand1Value - operand2Value)) ;
		if ((!result) && (currentState.signTimes)) result = result || (mainValue == operand1Value * operand2Value);
		if ((!result) && (currentState.signDivision)) result = result || (mainValue == operand1Value / operand2Value) || (mainValue == operand2Value / operand1Value);
		
		result = result && (ticTacToe);
	}
	return  result;	
}

- (BOOL) hasMovements
{
	for (int x=0; x<=kLastColumn; x++) 
	{
		for (int y=0; y<=kLastRow; y++) 
		{	
			PSBlock *block = board[x][y];
			if (block!=nil)
			{
					if (
						(block.value == STAR)
						||
						([self canOperate:block operand1:[self getBlock:x-1 :y] operand2:[self getBlock:x+1 :y]])
						||
						([self canOperate:block operand1:[self getBlock:x-1 :y-1] operand2:[self getBlock:x+1 :y+1]])
						||
						([self canOperate:block operand1:[self getBlock:x-1 :y+1] operand2:[self getBlock:x+1 :y-1]])
						||
						([self canOperate:block operand1:[self getBlock:x :y-1] operand2:[self getBlock:x :y+1]])
						)
							return YES;
			}
		}
	}
	
	return NO;
	
}

- (void) updateInfoDisplays
{	
	if (frameCount % 60 == 0)
	{
		counterTime--;
		[controlLayer setTimeBoard:counterTime];
		
		if ((counterTime==0) || (![self hasMovements]))
			[self gameOver];
	}
	//POR AQUI PASA 60 veces por segundo...y mi teclado siue loco xDD ok
	if (counterTime<=30)
	{
		if (counterTime % 10 == 0)
		{
			if (counterTime==30)
				speedEffect - 60;
			else if (counterTime==20)
				speedEffect = 30;
			else
				speedEffect = 20;
		}
			
		
		if (frameCount % speedEffect == 0)
			[[SimpleAudioEngine sharedEngine] playEffect:CONSTANT_SOUNDS_BLIP pitch:1 pan:0 gain:1];
	}
	
	[controlLayer setScoreBoard:counterScore];
}

- (void) disappearBlocks
{
	PSBlock *psblock = nil;
	for (int x=0; x<=kLastColumn; x++) {
		for (int y=0; y<=kLastRow; y++) {
			psblock = board[x][y];
			
			if (psblock!=nil && psblock.disappearing)
			{
				//I have to use the blast1 frame
				if (5 < psblock.opacity)
				{
					psblock.opacity -= 5;
					if (192 < psblock.opacity)
					{
						[psblock SetMarkedAs:BLAST1];
						if (!blowingUp)
						{
							blowingUp = YES;
							[[SimpleAudioEngine sharedEngine] playEffect:CONSTANT_SOUNDS_EXPLOSION_SOUND];
						}
					}
					else
						if (128 < psblock.opacity)
							[psblock SetMarkedAs:BLAST2];
						else
							if (64 < psblock.opacity)
								[psblock SetMarkedAs:BLAST3];
							else
								[psblock SetMarkedAs:BLAST4];
				}
				else
				{
					psblock.opacity = 0;
					[self removeChild:psblock cleanup:YES];
					psblock = nil;
					board[x][y] = nil;
					disappeared = YES;
					counterScore += pointsToAdd;
					if (counterScore<0) counterScore=0;
					blowingUp = NO;
				}
			}
		}
	}
}

- (void) computeScore 
{
	// Mark puyos in groupings set as disappearing and increase score.
	/*for (NSSet *grouping in groupings) {
		for (Puyo *puyo in grouping) {
			score += 10;
			puyo.disappearing = YES;
		}
	 */
}

- (void) checkForBlockGroupings:(PSBlock *)psblock
{
}

- (void) dealloc {
	//[self clearBoard];
	[self removeAllChildrenWithCleanup:YES];
	//[scoreLabel release];
	[super dealloc];
}
- (void) moveBlocksDown {	

	PSBlock *psblock = nil;
	/*
	for (int x = kLastColumn; x >= 0; x--) {
		for (int y = kLastRow; y >= 0; y--) {
			*/
			for (int x = 0; x <= kLastColumn; x++) {
				for (int y = 0; y <= kLastRow; y++) {
			
			psblock = board[x][y];
			
			// Is psblock "solid?" i.e. not disappearing?
			if (nil != psblock && !psblock.disappearing) {
				
				// Can this psblock drop down to the next cell?
				if ( 0 < y && (nil == board[x][y - 1]) ) {
					
					// Channel Bob Parker: Come on down!
					[self moveBlockDown:psblock];
					psblock.stuck = NO;		
					
				} else {
					// This psblock can't drop anymore, it's stuck.
					psblock.stuck = YES;
				}
				
			} // End of if (nil != psblock && !psblock.disappearing)
			
		} // End of for y loop.
	} // End of for x loop.
	
	
	if (disappeared)
	{
		[self resetBoard];
		disappeared = NO;
		fallen = YES;
	}
	if (fallen)
	{
		fallen = NO;
		[self fallenBlocks];
	}
}


@end
