//
//  PSData.h
//  plusSign
//
//  Created by Genki-Oki on 12/22/09.
//  Copyright 2009 Genki-Oki. All rights reserved.
//

#import <Foundation/Foundation.h>
#import "PSConstants.h"


@interface PSData : NSObject {
	
	tMODE mode;
	int score;
	int time;
	
	bool signPlus;
	bool signMinus;
	bool signTimes;
	bool signDivision;		
}

@property(nonatomic) bool signPlus, signMinus, signTimes, signDivision;
@property(nonatomic) int score, time;
@property(nonatomic) tMODE mode;

+ (PSData *)newPSData;
+ (PSData *)initPSData:(tMODE)mode;
+ (PSData *)initPSData:(tMODE)mode score:(int)points time:(int)seconds plusSign:(bool)plus minusSign:(bool)minus timesSign:(bool)times divisionSign:(bool)division;
- (void)loadData;
- (void)saveData;
- (NSString *)getKey;
- (BOOL)hasData;
- (BOOL) isGoalReached;

@end
