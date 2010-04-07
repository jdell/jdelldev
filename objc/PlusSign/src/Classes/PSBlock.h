//
//  PSBlock.h
//  plusSign
//
//  Created by Genki-Oki on 9/20/09.
//  Copyright 2009 Genki-Oki. All rights reserved.
//

#import <Foundation/Foundation.h>
#import "cocos2d.h"
#import "PSConstants.h"
#import "SimpleAudioEngine.h"

typedef enum psBlockValues{
	ONE = 1,
	TWO = 2,
	THREE = 3,
	FOUR = 4,
	FIVE = 5,
	SIX = 6,
	SEVEN = 7,
	EIGHT = 8,
	NINE = 9,
	LEAF = 10,
	STAR = 11,
	GREY = 12	
} PSBlockValue;

typedef enum BlockMarkTypes{
	NORMAL = 0,
	SELECTED = 1,
	OPERATED = 2,
	CLICKED = 3,
	BLAST1 = 4,
	BLAST2 = 5,
	BLAST3 = 6,
	BLAST4 = 7	
} BlockMarkType;

@interface PSBlock : Sprite{
	int boardX, boardY;
	PSBlockValue value;
	Animation *states;
	bool stuck, disappearing;
	BlockMarkType markedAs;
}

@property int boardX;
@property int boardY;
@property PSBlockValue value;
@property (nonatomic, retain) Animation *states;
@property bool stuck;
@property bool disappearing;
@property BlockMarkType markedAs;

+ (PSBlock *)newPSBlock;
+ (PSBlock *)newPSBlockWithOutSpecial;
+ (PSBlock *)newPSBlock:(PSBlockValue)val;
- (void) moveRight;
- (void) moveLeft;
- (void) moveDown;
- (void) moveUp;
- (CGRect) rect;
- (BOOL) isSpecialBlock;
- (void) SetMarkedAs:(BlockMarkType)markedAsParam;
- (void) SetActive:(BOOL)active;
@end

#define BLOCK_WIDTH 52
#define BLOCK_HEIGHT 52
#define BLOCK_VALUES 12 //1-9, leaf, star, gray

#define OFFSET_X 8
#define OFFSET_Y 60

#define COMPUTE_X(x) COMPUTE_X_S(x, BLOCK_WIDTH)
#define COMPUTE_X_S(x, size) (OFFSET_X + abs(x) * size)
#define COMPUTE_Y(y) COMPUTE_Y_S (y, BLOCK_HEIGHT) 
#define COMPUTE_Y_S(y, size) (OFFSET_Y + abs(y) * size) 
#define COMPUTE_X_Y(x, y) ccp(COMPUTE_X(x), COMPUTE_Y(y))
#define COMPUTE_X_Y_S(x, y, size) ccp(COMPUTE_X_S(x, size), COMPUTE_Y_S(y, size))

#define DECOMPUTE_X(x) DECOMPUTE_X_S(x, BLOCK_WIDTH)
#define DECOMPUTE_Y(y) DECOMPUTE_Y_S(y, BLOCK_HEIGHT) 
#define DECOMPUTE_X_S(x, size) (abs(x-OFFSET_X) / size)
#define DECOMPUTE_Y_S(y, size) (abs(y-OFFSET_Y) / size) 
#define DECOMPUTE_X_Y(x, y) ccp(DECOMPUTE_X(x), DECOMPUTE_Y(y))
#define DECOMPUTE_X_Y_S(x, y, size) ccp(DECOMPUTE_X_S(x, size), DECOMPUTE_Y_S(y, size))