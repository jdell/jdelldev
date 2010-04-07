//
//  VTSprite.h
//  plusSign
//
//  Created by Genki-Oki on 9/7/09.
//  Copyright 2009 Genki-Oki. All rights reserved.
//

#import <Foundation/Foundation.h>
#import "TSprite.h"

typedef enum vtspritesTypes{
	NORMAL = 0,
	SELECTED = 1,
	OPERATED = 2	
} VTSpriteTypes;


@interface VTSprite : TSprite {
	VTSpriteTypes type;	
	
	Animation *states;
	
	int value;
}

@property (nonatomic, retain) Animation *states;
+(VTSprite *)GetMainSelected;
+(void)Reset;
+ (id) vtsspriteWithFiles:(int)numericValue: (NSString *)imageFileNormal: (NSString *)imageFileSelected: (NSString *)imageFileOperated;

- (void) SetType:(VTSpriteTypes)typeParam;
- (VTSpriteTypes) GetType;

- (void) SetValue:(int)valueParam;
- (int) GetValue;

@end

